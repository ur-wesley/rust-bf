using Oxide.Game.Rust.Cui;
using System;
using System.Linq.Expressions;
using UnityEngine;

namespace Oxide.Plugins {
    [Info("Test", "wesley", 0.1)]
    [Description("test")]
    public class bfmode : RustPlugin {
        [ChatCommand("bf"), Permission("bfmode.use")]
        void GetKit(BasePlayer player, string command, string[] args) {
            // oxide.grant user wesley bfmode.kit
            if (permission.UserHasPermission(player.UserIDString, "bfmode.kit")) { }
            switch (args[0])
            {
                case "kit":
                    SelectKit(player);
                    break;
                case "red":
                    //setPlayerRedSite
                    //CreateMenu(player);
                    break;
                case "blue":
                    //setPlayerBlueSite
                    //CreateMenu(player);
                    break;
                default:
                    break;
            }
        }

        void SelectKit(BasePlayer player) {
            var mainElements = new CuiElementContainer();
            var mainPanel = mainElements.Add(new CuiPanel
            {
                Image =
                {
                    Color = "0.1 0.1 0.1 0.8"
                },
                RectTransform =
                {
                    AnchorMin = "0.2 0.2",
                    AnchorMax = "0.8 0.8"
                },
                CursorEnabled = true
            });

            var closeButton = new CuiButton
            {
                Button =
                {
                    Close = mainPanel,
                    Color = "0.8 0 0 1"
                },
                RectTransform =
                {
                    AnchorMin = "0.94 0.94",
                    AnchorMax = "0.99 0.99"
                },
                Text =
                {
                    Text = "x",
                    Color = "0 0 0 1",
                    FontSize = 22,
                    Align = TextAnchor.MiddleCenter
                }
            };
            mainElements.Add(closeButton, mainPanel);
            var mainCaption = new CuiLabel
            {
                RectTransform =
                {
                    AnchorMin = "0.1 0.9",
                    AnchorMax = "0.7 1"
                },
                Text =
                {
                    Text = "Battlefield",
                    FontSize = 36,
                    Color = "1 1 1 1"
                }
            };
            mainElements.Add(mainCaption, mainPanel);
            var medicComponents = new CuiElementContainer();
            var medicPanel = new CuiPanel
            {
                Image =
                        {
                Color = "1 1 1 1"
                        },
                RectTransform =
                {
                AnchorMin = "0.04 0.04",
                    AnchorMax = "0.27 0.8"
                }
            };
            medicComponents.Add(medicPanel);
            var medicLabel = new CuiLabel
            {
                RectTransform =
                        {
                    AnchorMin = "0.04 0.04",
                    AnchorMax = "0.27 0.8"
                        },
                Text =
                        {
                            Text = "Medic"
                        }
            };
            medicComponents.Add(medicLabel);
            new CuiElement
            {
                Components = {

                        }
            };
            CuiHelper.AddUi(player, mainElements);
        }

        void Loaded() {
            Puts("Loaded BF mode");
        }
    }
}
