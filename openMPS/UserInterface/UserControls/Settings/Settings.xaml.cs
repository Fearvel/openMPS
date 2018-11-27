﻿#region Copyright

// Copyright (c) 2018, Andreas Schreiner

#endregion

using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using de.fearvel.openMPS.Database;

namespace de.fearvel.openMPS.UserInterface.UserControls.Settings
{
    /// <summary>
    ///     Settings Namespace
    /// </summary>
    [CompilerGenerated]
    internal class NamespaceDoc
    {
    }

    /// <summary>
    ///     Interaktionslogik für Settings.xaml
    /// </summary>
    public partial class Settings : UserControl
    {
        /// <summary>
        ///     array of Usercontrols
        /// </summary>
        private readonly UserControl[] _ucontrols = new UserControl[3];

        /// <summary>
        ///     Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        public Settings()
        {
            InitializeComponent();
            Loaded += EinstellungenMain_Load;
        }

        /// <summary>
        ///     Handles the Load event of the Settings control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs" /> instance containing the event data.</param>
        public void EinstellungenMain_Load(object sender, RoutedEventArgs e)
        {
            trv_einstellungen.Items.Clear();
            loadTreeview();
            _ucontrols[0] = new BasicInformation();
            _ucontrols[1] = new EinstellungenOid();
      //      _ucontrols[2] = new EinstellungenTechniker();

            grid_setting.Children.Add(_ucontrols[0]);
        }

        /// <summary>
        ///     builds the treeview.
        /// </summary>
        private void loadTreeview()
        {
            var dt =Config.GetInstance().Query(
                "Select * from TRVSETTINGS where Name='settings_trv_item' and isEnabled='1' and isSubitem='0' and hasSubitem='1'");
            for (var i = 0; i < dt.Rows.Count; i++)
                trv_einstellungen.Items.Add(buildMenueItem(dt.Rows[i].Field<string>("Value"),
                    dt.Rows[i].Field<long>("id")));
            var logout = new TreeViewItem();
            var login = new TreeViewItem
            {
                IsExpanded = true,
                Header = "Techniker Login",
                ItemsSource = new string[] { }
            };
            trv_einstellungen.Items.Add(login);
        }

        /// <summary>
        ///     Builds the treeview for technik.
        /// </summary>
        private void loadTreeviewTechnik()
        {
            var dt =Config.GetInstance().Query(
                "Select * from TRVSETTINGS where Name like 'settings_trv_item%' and isEnabled='1' and isSubitem='0' and hasSubitem='1'");
            for (var i = 0; i < dt.Rows.Count; i++)
                trv_einstellungen.Items.Add(buildMenueItemTechnik(dt.Rows[i].Field<string>("Value"),
                    dt.Rows[i].Field<long>("id")));
            var logout = new TreeViewItem
            {
                IsExpanded = true,
                Header = "Logout",
                ItemsSource = new string[] { }
            };
            trv_einstellungen.Items.Add(logout);
        }

        /// <summary>
        ///     Builds a TreeViewItem
        /// </summary>
        /// <param name="header">The header.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        private TreeViewItem buildMenueItem(string header, long id)
        {
            var item = new TreeViewItem
            {
                IsExpanded = true,
                Header = header
            };
            var dts =Config.GetInstance().Query(
                "Select * from TRVSETTINGS where Name='settings_trv_item' and isEnabled='1'" +
                "and hasSubitem='0' and isSubitem='1' and isSubitemOf=" + id + ";");
            if (dts.Rows.Count > 0)
            {
                var data = new string[dts.Rows.Count];
                for (var k = 0; k < dts.Rows.Count; k++) data[k] = dts.Rows[k].Field<string>("Value");
                item.ItemsSource = data;
            }

            dts =Config.GetInstance().Query(
                "Select * from TRVSETTINGS where Name='settings_trv_item' and isEnabled='1'" +
                "and hasSubitem='1' and isSubitem='1' and isSubitemOf=" + id + ";");
            for (var k = 0; k < dts.Rows.Count; k++)
                item.Items.Add(buildMenueItem(dts.Rows[k].Field<string>("Value"), dts.Rows[k].Field<long>("id")));
            return item;
        }

        /// <summary>
        ///     Builds a TreeViewItem for technik
        /// </summary>
        /// <param name="header">The header.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        private TreeViewItem buildMenueItemTechnik(string header, long id)
        {
            var item = new TreeViewItem
            {
                IsExpanded = true,
                Header = header
            };
            var dts =Config.GetInstance().Query(
                "Select * from TRVSETTINGS where Name like 'settings_trv_item%'  and isEnabled='1'" +
                "and hasSubitem='0' and isSubitem='1' and isSubitemOf=" + id + ";");
            if (dts.Rows.Count > 0)
            {
                var data = new string[dts.Rows.Count];
                for (var k = 0; k < dts.Rows.Count; k++) data[k] = dts.Rows[k].Field<string>("Value");
                item.ItemsSource = data;
            }

            dts =Config.GetInstance().Query(
                "Select * from TRVSETTINGS where Name='settings_trv_item' and isEnabled='1'" +
                "and hasSubitem='1' and isSubitem='1' and isSubitemOf=" + id + ";");
            for (var k = 0; k < dts.Rows.Count; k++)
                item.Items.Add(buildMenueItem(dts.Rows[k].Field<string>("Value"), dts.Rows[k].Field<long>("id")));
            return item;
        }

        /// <summary>
        ///     Handles the SelectedItemChanged event of the trv_einstellungen control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        ///     The <see cref="System.Windows.RoutedPropertyChangedEventArgs{System.Object}" /> instance containing the
        ///     event data.
        /// </param>
        private void trv_einstellungen_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            try
            {
                var cmd = "Select * from TRVSETTINGS where not UC=-1 and Value='" + trv_einstellungen.SelectedValue +
                          "';";
                var dt =Config.GetInstance().Query(cmd);
                if (dt.Rows.Count == 1)
                {
                    grid_setting.Children.Clear();
                    var a = Convert.ToInt32(dt.Rows[0].Field<long>("UC"));
                    grid_setting.Children.Add(_ucontrols[Convert.ToInt32(dt.Rows[0].Field<long>("UC"))]);
                }
                else if (trv_einstellungen.SelectedValue.ToString().Contains("Login"))
                {
                   //ALTER Techniker Login
                }
                else if (trv_einstellungen.SelectedValue.ToString().Contains("Logout"))
                {
                    trv_einstellungen.Items.Clear();
                    loadTreeview();
                    grid_setting.Children.Clear();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}