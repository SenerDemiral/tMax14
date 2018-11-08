using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraMap;

namespace tMax14.Genel
{
    public partial class mapXF : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.XtraMap.GeoPoint GP = new GeoPoint();

        const string bingKey = "ArIJFr_vxZwpQK8CCWf4oq2AKfA1u-W64-a_XlDoy8DPG9EParqkCBl7OAbeWY9t";
        MapControl map;
        BingSearchDataProvider searchProvider;
        
        public mapXF()
        {
            InitializeComponent();

            //mapControl1.ZoomLevel = 10;
            //ImageTilesLayer layer = mapControl1.Layers[0] as ImageTilesLayer;
            //BingMapDataProvider provider = new BingMapDataProvider();
            //provider.BingKey = "ArIJFr_vxZwpQK8CCWf4oq2AKfA1u-W64-a_XlDoy8DPG9EParqkCBl7OAbeWY9t";
            //layer.DataProvider = provider;

            PrepareMap();
            searchProvider.SearchCompleted += searchProvider_SearchCompleted;
        }

        void searchProvider_SearchCompleted(object sender, BingSearchCompletedEventArgs e)
        {
            
            SearchRequestResult result = e.RequestResult;

            if (result.ResultCode == RequestResultCode.Success)
            {
                LocationInformation region = result.SearchRegion;

               if (region != null)
                {
                    NavigateTo(region.Location);
                }
                else
                {
                    if (result.SearchResults.Count > 0)
                        NavigateTo(result.SearchResults[0].Location);
                }
                //DisplayResults(e.RequestResult);
            }

            if (result.ResultCode == RequestResultCode.BadRequest)
                XtraMessageBox.Show("The Bing Search service does not work for this location.");
        }

        void NavigateTo(GeoPoint geoPoint)
        {
            map.CenterPoint = geoPoint;
        }
        
        private void mapXF_Load(object sender, EventArgs e)
        {
        }
        
        public void MapCenter(string LOCid)
        {
            try
            {
                this.lOC_COORDINATETableAdapter.Fill(this.genelDataSet.LOC_COORDINATE, LOCid);
                string keyword = this.genelDataSet.LOC_COORDINATE[0].KEYWORD;
                GP.Latitude = this.genelDataSet.LOC_COORDINATE[0].NORTH;
                GP.Longitude = this.genelDataSet.LOC_COORDINATE[0].EAST;

                searchProvider.ClearResults();
                if (GP.Latitude == 0 && GP.Longitude == 0)
                    searchProvider.Search(keyword);
                else
                    map.CenterPoint = GP;
                //GP.Latitude = this.genelDataSet.LOC_COORDINATE[0].NORTH;
                //GP.Longitude = this.genelDataSet.LOC_COORDINATE[0].EAST;
                //mapControl1.CenterPoint = GP; //new DevExpress.XtraMap.GeoPoint(this.genelDataSet.LOC_COORDINATE[0].NORTH, this.genelDataSet.LOC_COORDINATE[0].EAST);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        
        private void bingMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            ImageTilesLayer layer = mapControl1.Layers[0] as ImageTilesLayer;
            BingMapDataProvider provider = new BingMapDataProvider();
            provider.BingKey = "ArIJFr_vxZwpQK8CCWf4oq2AKfA1u-W64-a_XlDoy8DPG9EParqkCBl7OAbeWY9t";
            layer.DataProvider = provider;*/
        }

        private void openStreetMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            ImageTilesLayer layer = mapControl1.Layers[0] as ImageTilesLayer;
            OpenStreetMapDataProvider provider = new OpenStreetMapDataProvider();
            layer.DataProvider = provider;*/
        }

        private void mapXF_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*mapControl1.Dispose();*/
        }

        private void PrepareMap()
        {
            // Create a map control.
            map = new MapControl();
            map.ZoomLevel = 8;

            // Specify the map position on the form.           
            map.Dock = DockStyle.Fill;

            // Add the map control to the window.
            this.Controls.Add(map);

            // Bring the map to the front.
            map.BringToFront();

            // Create an image tiles layer and add it to the map.
            ImageTilesLayer tilesLayer = new ImageTilesLayer();
            map.Layers.Add(tilesLayer);

            // Create an information layer and add it to the map.
            InformationLayer infoLayer = new InformationLayer();
            map.Layers.Add(infoLayer);

            // Create a Bing data provider and specify the Bing key.
            BingMapDataProvider bingProvider = new BingMapDataProvider();
            tilesLayer.DataProvider = bingProvider;
            bingProvider.BingKey = bingKey;

            // Create a Bing search data provider and specify the Bing key.
            searchProvider = new BingSearchDataProvider();
            infoLayer.DataProvider = searchProvider;
            searchProvider.BingKey = bingKey;
            //searchProvider.ShowSearchPanel = false;
        }

    }
}