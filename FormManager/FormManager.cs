using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormManagerdll
{
    public class FormManager
    {
        private static FormManager _instance = new FormManager();
        public static FormManager Instance { get { return _instance; } }
        /// <summary>
        /// 頁面暫存器
        /// </summary>
        private Dictionary<string, UserControl> page_Dic;
        /// <summary>
        /// 主體Controls
        /// </summary>
        private Control controls;
        /// <summary>
        /// Panel名稱
        /// </summary>
        private string context_name;
        /// <summary>
        /// 當前畫面
        /// </summary>
        private string now_page = "";

        private string back_name = "";

        public FormManager() { }
        public FormManager(Control ctl,string name) { 
            page_Dic = new Dictionary<string, UserControl>();
            controls = ctl;
            context_name = name;
        }

        public bool AddPage(string name , UserControl uc) {
            if (!page_Dic.TryGetValue(name,out UserControl value)) {
                page_Dic.Add(name, uc);
                return true;
            }
            return false;            
        }

        public bool RemovePage(string name) {
            if (page_Dic.TryGetValue(name, out UserControl value))
            {
                value.Dispose();
                value = null;
                page_Dic.Remove(name);
                GC.Collect();
                return true;
            }
            return false;
        }

        public bool ClearPage() {
            try
            {                                
                Panel panel = controls.Controls.Find(context_name, false)[0] as Panel;
                panel.Controls.Clear();
                    
                now_page = "";
                return true;                
            }
            catch (Exception ex) { return false; }            
        }

        public void BackPage()
        {
            SetPage(back_name);
        }

        public bool SetPage(string name)
        {
            try
            {
                if (now_page == name) return false;
                if (page_Dic.TryGetValue(name, out UserControl value))
                {
                    value.Dock = DockStyle.Fill;
                    Panel panel = controls.Controls.Find(context_name, false)[0] as Panel;
                    panel.Controls.Clear();
                    panel.Controls.Add(value);
                    now_page = name;
                    back_name = name;
                    return true;
                }
            }
            catch (Exception ex) { return false; }

            return false;
        }

        public bool ResetPage(string name) {
            try
            {
                if (now_page == "") return false;
                if (page_Dic.TryGetValue(name, out UserControl value))
                {
                    Panel panel = controls.Controls.Find(context_name, false)[0] as Panel;
                    
                    panel.Controls.Remove(value);                    
                    now_page = "";
                    back_name = "";
                    return true;
                }
            }
            catch (Exception ex) { return false; }

            return false;
        }

        public string GetNowPageName() {
            return now_page;
        }
    }
}
