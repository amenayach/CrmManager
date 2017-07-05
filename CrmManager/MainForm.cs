using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmManager.Controls;
using CrmManager.Crm;

namespace CrmManager
{
	public partial class MainForm : Form
	{

		private Manager _crmManager;
		private string _crmUrl;
		private DateTime _waitStart;

		public MainForm()
		{
			InitializeComponent();
			_crmUrl = ControlMod.GetRegistryValue(ControlMod.cntConStr) as string;
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			var url = ControlMod.InputBox(string.Empty, "Enter CRM connection string", _crmUrl);
			if (!string.IsNullOrWhiteSpace(url))
			{
				_crmUrl = url;
				// ReSharper disable once LocalizableElement
				Text = $"CRM Manager - {_crmUrl}";
				ControlMod.SetRegistryValue(ControlMod.cntConStr, _crmUrl);
				_crmManager = new Manager(_crmUrl);
				InitEntitiesList();
			}
		}

		private void InitEntitiesList()
		{
			Wait();

			var entities = _crmManager.GetAllEntities();

			if (entities?.Count > 0)
			{
				lstEntities.Items.Clear();
				lstEntities.Items.AddRange(entities.Cast<object>().ToArray());
			}

			Wait(false);

		}

		private void lstEntities_SelectedIndexChanged(object sender, EventArgs e)
		{
			AddTab(lstEntities.SelectedItem.ToString());
		}

		private void tabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabs.SelectedIndex == tabs.TabPages.Count - 1 && tabs.SelectedTab.Text == "+")
			{
				AddTab();
			}
		}

		private void AddTab(string initQuery = "")
		{
			tabs.TabPages.Insert(tabs.TabCount - 1, $"Query{tabs.TabCount}");
			tabs.SelectedTab = tabs.TabPages[tabs.TabCount - 2];

			var ctrl = new QueryUC()
			{
				Manager = _crmManager,
				Dock = DockStyle.Fill
			};

			ctrl.SetQuery(initQuery);

			tabs.SelectedTab.Controls.Add(ctrl);
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F5)
			{
				Exec();
			}
		}

		private void Exec()
		{
			if (tabs.SelectedTab.Controls.Count > 0)
			{
				Wait();
				var ctrl = tabs.SelectedTab.Controls[0] as QueryUC;
				ctrl?.Exec();
				Wait(false);
			}
		}

		private void Wait(bool doWait = true)
		{
			if (doWait)
			{
				_waitStart = DateTime.Now;
				lblStatus.Text = "Please wait...";
				Application.DoEvents();
			}
			else
			{
				lblStatus.Text = $"exec time {(DateTime.Now - _waitStart).TotalSeconds.ToString("0.##")}ms";
				Application.DoEvents();
			}
		}

		private void btnExec_Click(object sender, EventArgs e)
		{
			Exec();
		}
	}
}
