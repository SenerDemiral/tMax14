namespace tMax14.Account
{


    public partial class AccountDataSet
    {

        partial class ACSDataTable
        {
        }

        partial class AHTDataTable
        {
        }

        partial class AOD_SEL_KALANLARDataTable
        {
        }

        partial class AFBLDataTable
        {
        }

        partial class AFDDataTable
        {
        }

        partial class AFBDataTable
        {
        }

        partial class DVZ_SELDataTable
        {
        }

        partial class AFB_REC_SELDataTable
        {
        }
    }
}

namespace tMax14.Account.AccountDataSetTableAdapters {
    
    
    public partial class AODTableAdapter {
        /*
        private global::FirebirdSql.Data.FirebirdClient.FbTransaction _transaction;
        
        internal global::FirebirdSql.Data.FirebirdClient.FbTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (this.Adapter != null && this.Adapter.DeleteCommand != null)
                {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (this.Adapter != null && this.Adapter.InsertCommand != null)
                {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (this.Adapter != null && this.Adapter.UpdateCommand != null)
                {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        */
    } 
}

namespace tMax14.Account.AccountDataSetTableAdapters {
    
    
    public partial class AFBTableAdapter {

        Account.AccountDataSet.AFBDataTable fresh;

        void Adapter_RowUpdated(object sender, FirebirdSql.Data.FirebirdClient.FbRowUpdatedEventArgs e)
        {
            if (e.StatementType == System.Data.StatementType.Insert || e.StatementType == System.Data.StatementType.Update)
            {
                ClearBeforeFill = false;
                Fill(fresh, string.Format("AFBid = {0}", e.Row["AFBID"]), Program.USR);
            }
        }

        public void Save(Account.AccountDataSet.AFBDataTable dt)
        {
            fresh = dt;
            Adapter.RowUpdated += Adapter_RowUpdated;
            Adapter.Update(dt);
            Adapter.RowUpdated -= Adapter_RowUpdated;
        }
    }

    public partial class AVBTableAdapter
    {
        Account.AccountDataSet.AVBDataTable fresh;

        void Adapter_RowUpdated(object sender, FirebirdSql.Data.FirebirdClient.FbRowUpdatedEventArgs e)
        {
            if (e.StatementType == System.Data.StatementType.Insert || e.StatementType == System.Data.StatementType.Update)
            {
                ClearBeforeFill = false;
                Fill(fresh, string.Format("AVB.AVBid = {0}", e.Row["AVBID"]), Program.USR);
            }
        }

        public void Save(Account.AccountDataSet.AVBDataTable dt)
        {
            fresh = dt;
            Adapter.RowUpdated += Adapter_RowUpdated;
            Adapter.Update(dt);
            Adapter.RowUpdated -= Adapter_RowUpdated;
        }
    }

    public partial class AVDTableAdapter
    {
        Account.AccountDataSet.AVDDataTable fresh;

        void Adapter_RowUpdated(object sender, FirebirdSql.Data.FirebirdClient.FbRowUpdatedEventArgs e)
        {
            if (e.StatementType == System.Data.StatementType.Insert || e.StatementType == System.Data.StatementType.Update)
            {
                ClearBeforeFill = false;
                int PK = (int)e.Row["AVDID"];
                int nor = Fill(fresh, (int)e.Row["AVDID"]);
            }
        }

        public void Save(Account.AccountDataSet.AVDDataTable dt)
        {
            fresh = dt;
            Adapter.RowUpdated += Adapter_RowUpdated;
            Adapter.Update(dt);
            Adapter.RowUpdated -= Adapter_RowUpdated;
        }
    }
}
