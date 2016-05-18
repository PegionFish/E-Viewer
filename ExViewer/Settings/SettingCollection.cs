﻿using Windows.UI.Xaml;

namespace ExViewer.Settings
{
    public class SettingCollection : SettingCollectionBase
    {
        public static SettingCollection Current
        {
            get;
            private set;
        } = new SettingCollection();

        [Roaming]
        [Setting("Searching", "Save my lastest search as default", Index = 30)]
        public bool SaveLastSearch
        {
            get
            {
                return GetRoaming(false);
            }
            set
            {
                SetRoaming(value);
            }
        }

        [Roaming]
        [Setting("Searching", "Default keywords on the front page", Index = 10)]
        public string DefaultSearchString
        {
            get
            {
                return GetRoaming("");
            }
            set
            {
                SetRoaming(value);
            }
        }

        [Roaming]
        [Setting(
            "Searching",
            "Default categories on the front page",
            Index = 20,
            SettingPresenterTemplate = "CatagorySettingTemplate"
        )]
        public ExClient.Category DefaultSearchCategory
        {
            get
            {
                return GetRoaming(ExClient.Category.All);
            }
            set
            {
                SetRoaming(value);
            }
        }

        [Setting("Global", "The theme of the app (Need restart the app)", Index = -10)]
        public ApplicationTheme Theme
        {
            get
            {
                return GetLocal(ApplicationTheme.Dark);
            }
            set
            {
                SetLocal(value);
            }
        }

        [Setting("Image viewing", "Zoom factor for double tapping", Index = 10)]
        [SingleRange(1, 4, Small = 0.1)]
        public float DefaultFactor
        {
            get
            {
                return GetLocal(2f);
            }
            set
            {
                SetLocal(value);
            }
        }

        [Setting("Image viewing", "Maximum zoom factor", Index = 20)]
        [SingleRange(4, 8, Small = 0.1)]
        public float MaxFactor
        {
            get
            {
                return GetLocal(8f);
            }
            set
            {
                SetLocal(value);
            }
        }

        [Setting("Image viewing", "Factor for inertia of mouse dragging (Set to 0 to disable)", Index = 30)]
        [DoubleRange(0, 1, Small = 0.05)]
        public double MouseInertialFactor
        {
            get
            {
                return GetLocal(0.5);
            }
            set
            {
                SetLocal(value);
            }
        }

        [Setting("Image viewing", "The latency for the command bar to hide or show after tapping", Index = 40)]
        [Int32Range(0, 1000, Tick = 100, Small = 10, Large = 100)]
        public int ChangeCommandBarDelay
        {
            get
            {
                return GetLocal(150);
            }
            set
            {
                SetLocal(value);
            }
        }

        [Setting("Connection", "Load compressed image while using metered Internet connection", Index = 10)]
        [BooleanRepresent("Yes", "No")]
        public bool LoadLofiOnMeteredInternetConnection
        {
            get
            {
                return GetLocal(true);
            }
            set
            {
                if(LoadLofiOnAllInternetConnection)
                    ForceSetLocal(true);
                else
                    ForceSetLocal(value);
            }
        }

        [Setting("Connection", "Always load compressed image", Index = 20)]
        [BooleanRepresent("Yes", "No")]
        public bool LoadLofiOnAllInternetConnection
        {
            get
            {
                return GetLocal(false);
            }
            set
            {
                SetLocal(value);
                if(value)
                    LoadLofiOnMeteredInternetConnection = true;
            }
        }

        [Setting("H@H", "IP Address:Port (Leave blank to not use)", Index = 10)]
        public string HahAddress
        {
            get
            {
                return GetLocal("");
            }
            set
            {
                var old = GetLocal("");
                if(string.IsNullOrWhiteSpace(value))
                    ForceSetLocal("");
                else
                    try
                    {
                        var hah = new ExClient.HahProxyConfig(value);
                        ForceSetLocal(hah.AddressAndPort);
                    }
                    catch
                    {
                        ForceSetLocal(old);
                    }
            }
        }

        [Setting("H@H", "Passkey (Optional)", Index = 20)]
        public string HahPasskey
        {
            get
            {
                return GetLocal("");
            }
            set
            {
                ForceSetLocal((value ?? "").Trim());
            }
        }
    }
}
