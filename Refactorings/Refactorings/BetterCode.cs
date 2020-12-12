using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
namespace Refactorings
{
    class BetterCode
    {
        private void set_mode(bool mod) //done
        {
            label1.Enabled = mod;
            button1.Enabled = mod;
            button2.Enabled = mod;
            button3.Enabled = !mod;
            button4.Enabled = !mod;
        }
        public string Foo() //done
        {
            return m_driverStatusNames[driver.Status];
        }
        public void Sth() //done
        {
            uint i = 15;
            if (i < 10)
            {

            }
        }
        public void Sth4() //done
        {
            string destination = null;
            destination = String.Join(string.Empty, source);
        }
        public bool IsNumber(string str) //done
        {
            int tester = 0;
            return int.TryParse(str, out tester);
        }
        public void Sth6() //????
        {
            foreach (DirectoryInfo dir in dirs.GetDirectories())
            {
                //create folder{16}
                stream.Write(new byte[] { (byte)NetworkMessage.MakeDir }, 0, 1);
                stream.Read(new byte[1], 0, 1);
                stream.Write(BitConverter.GetBytes(Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')).Length), 0, 4);
                stream.Write(Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')), 0, Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')).Length);
                //send folder name stream.Read(new byte[1], 0, 1);//Ok
                stream.Read(new byte[1], 0, 1);//Ok
            }
        }
        public void Sth7() //done
        {
            String[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        }
        public void Sth8() //done
        {
            DateTime dt = DateTime.Now;
            string[] arr = dt.ToLongTimeString().Split(':');
            string h = arr[0];
            string m = arr[1];
            string s = arr[2];
            Console.WriteLine("--" + h + ":" + m + ":" + s + "--");
        }
        public bool Sth9() //done
        {
            return (Counter % 2 != 0 && Counter / 10.0 != 0);
        }
        public void Sth10() //done
        {
            if (Connected == 0)
            {
                rez = setup();
            }
            fl_end = true;
        }
        public void Sth11() //done
        {
            List<int> arr = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 100)
                {
                    arr.Remove(arr[i]);
                }
            }
        }
        public void Sth12() //done
        {
            var ids = form.Keys;
            if (ids.Length != 1)
            {
                throw new Exception();
            }
        }
        public void Sth13() //done
        {
            string[] nameParts = customer.Name.Split(' ');
            string firstName = nameParts[0];
            string lastName = nameParts[1];
        }
        public void Sth14() //done
        {
            sourceId = Convert.ToInt32(sourceIDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)[0]);
        }
        public string generateEMail() //done
        {
            string res;
            PersonName = PersonName.Replace(' ', '.');
            if (PersonName.Length >= 20)
                res = PersonName.Substring(0, 20);
            else
                res = PersonName.Substring(0, PersonName.Length);
            res += "@domain.ua";
            return res;
        }
        public void Sth16() //done
        {
            sourceId = Convert.ToInt32(sourceIDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)[0]);
        }
        string GetTextDiv2(string text) //done
        {
            string[] mas = text.Split(' ');
            switch (mas.Length)
            {
                case 1:
                    return "&nbsp" + mas[0];
                case 2:
                    return "&nbsp" + mas[0] + " " + mas[1];
                default:
                    return "&nbsp" + String.Join(" ", mas.Take((mas.Length + 1) / 2).ToArray()) + " <br/>&nbsp " + String.Join(" ", mas.Skip((mas.Length + 1) / 2).ToArray());
            }
        }
        public void Sth18() //done
        { }
        private static readonly char SPECIFIER = "$"[0];
        private static readonly char DELIMITER = ":"[0];
        private static readonly char[] DELIMITER_ARRAY = { DELIMITER };
        public void Sth19() //done
        {
            string mailTo = String.IsNullOrEmpty(Config.GetSetting("AdminNotifications_EmailAddress")) ? Globals.GetHostPortalSettings().HostSettings["SMTPPassword"].ToString() : Config.GetSetting("AdminNotifications_EmailAddress");
        }
        public bool CheckPath(string path) //done
        {
            return File.Exists(path + "analit.dbf") && File.Exists(path + "partner.dbf") && File.Exists(path + "SCLAD\\mdoc.dbf") && File.Exists(path + "SCLAD\\mdoc.fpt") && File.Exists(path + "SCLAD\\mdocm.dbf") && File.Exists(path + "SCLAD\\mgrup.dbf") && File.Exists(path + "SCLAD\\mlabel.dbf") && File.Exists(path + "SCLAD\\mlabel.fpt") && File.Exists(path + "REAL\\rbookm.dbf") && File.Exists(path + "REAL\\rbook.dbf") && File.Exists(path + "REAL\\rbook.fpt") && File.Exists(path + "DOSTAVKA\\avt.dbf") && File.Exists(path + "DOSTAVKA\\avtm.dbf") && File.Exists(path + "DOSTAVKA\\avtm.fpt") && File.Exists(path + "DOSTAVKA\\cargo.dbf") && File.Exists(path + "DOSTAVKA\\cargom.dbf") && File.Exists(path + "DOSTAVKA\\zamena.dbf");
        }
        public void Sth21() //done
        {
            txtContacts.Text = String.Join(";", contacts);
        }
        public void Sth22() //done
        {
            Game1.clou = !Game1.clou;
        }
    }
}