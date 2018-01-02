using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1: OLEDBConnection
    {
        private string v;

        public Class1(string v)
        {
            this.v = v;
        }

        public void CancelRefresh()
        {
            throw new NotImplementedException();
        }

        public void MakeConnection()
        {
            throw new NotImplementedException();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public void SaveAsODC(string ODCFileName, object Description, object Keywords)
        {
            throw new NotImplementedException();
        }

        public void Reconnect()
        {
            throw new NotImplementedException();
        }

        public Application Application => throw new NotImplementedException();

        public XlCreator Creator => throw new NotImplementedException();

        public object Parent => throw new NotImplementedException();

        public object ADOConnection => throw new NotImplementedException();

        public bool BackgroundQuery { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object CommandText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public XlCmdType CommandType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object Connection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool EnableRefresh { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object LocalConnection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool MaintainConnection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime RefreshDate => throw new NotImplementedException();

        public bool Refreshing => throw new NotImplementedException();

        public bool RefreshOnFileOpen { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int RefreshPeriod { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public XlRobustConnect RobustConnect { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool SavePassword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SourceConnectionFile { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SourceDataFile { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool OLAP => throw new NotImplementedException();

        public bool UseLocalConnection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MaxDrillthroughRecords { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsConnected => throw new NotImplementedException();

        public XlCredentialsMethod ServerCredentialsMethod { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ServerSSOApplicationID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AlwaysUseConnectionFile { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ServerFillColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ServerFontStyle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ServerNumberFormat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ServerTextColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool RetrieveInOfficeUILang { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public CalculatedMembers CalculatedMembers => throw new NotImplementedException();

        public int LocaleID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
