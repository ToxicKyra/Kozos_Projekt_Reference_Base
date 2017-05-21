using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dynamic_Games;
using System.Reflection;

namespace DynamicGamesTests
{
    [TestClass]
    public class EndToEnd
    {
        //1
        [TestMethod]
        public void NonCoopertiv_Open_Close_Window_From_MenuForm()
        {

            var nonCooperativ = new NonCoopForm();
            if (nonCooperativ == null)
            {
                Assert.Fail();
            }
            nonCooperativ.NoPTB.Text = "10";
            if (nonCooperativ.NoPTB.Text != "10")
            {
                Assert.Fail();
            }
            nonCooperativ.InvestmentTB.Text = "10";
            if (nonCooperativ.InvestmentTB.Text != "10")
            {
                Assert.Fail();
            }
            nonCooperativ.InvestmentTB.Text = "10";
            if (nonCooperativ.InvestmentTB.Text != "10")
            {
                Assert.Fail();
            }
            nonCooperativ.RuleParamTB.Text = "10";
            if (nonCooperativ.RuleParamTB.Text != "10")
            {
                Assert.Fail();
            }
            nonCooperativ.RuleParamTB.Text = "Neighbors Decide";
            if (nonCooperativ.RuleParamTB.Text != "Neighbors Decide")
            {
                Assert.Fail();
            }
            MethodInfo MethodButton1_Click = nonCooperativ.GetType().GetMethod("Button1_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodButton1_Click.Invoke(nonCooperativ, new object[] { null, null});
            MethodInfo MethodExit = nonCooperativ.GetType().GetMethod("Exit", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodExit.Invoke(nonCooperativ, new object[] { });
            if (nonCooperativ.IsAccessible != false)
                Assert.Fail();
        }
        //2
        [TestMethod]
        public void Coopertiv_Open_Close_Window_From_MenuForm()
        {
            var cooperativ = new CoopForm();
            MethodInfo MethodbuttonStart_Click = cooperativ.GetType().GetMethod("buttonStart_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonStart_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStart.Text != "   Pause")
                Assert.Fail();
            MethodInfo MethodExit = cooperativ.GetType().GetMethod("Exit", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodExit.Invoke(cooperativ, new object[] { });
            if (cooperativ.IsAccessible != false)
                Assert.Fail();
        }
        //3
        [TestMethod]
        public void Coopertiv_Open_Pause_Close_Window_From_MenuForm()
        {
            var cooperativ = new CoopForm();
            MethodInfo MethodbuttonStart_Click = cooperativ.GetType().GetMethod("buttonStart_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonStart_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStart.Text != "   Pause")
                Assert.Fail();
            MethodbuttonStart_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStart.Text != "   Resume")
                Assert.Fail();
            MethodInfo MethodExit = cooperativ.GetType().GetMethod("Exit", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodExit.Invoke(cooperativ, new object[] { });
            if (cooperativ.IsAccessible != false)
                Assert.Fail();
        }
        //4
        [TestMethod]
        public void Coopertiv_Open_Pause_Resume_Close_Window_From_MenuForm()
        {
            var cooperativ = new CoopForm();
            MethodInfo MethodbuttonStart_Click = cooperativ.GetType().GetMethod("buttonStart_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonStart_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStart.Text != "   Pause")
                Assert.Fail();
            MethodbuttonStart_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStart.Text != "   Resume")
                Assert.Fail();
            MethodbuttonStart_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStart.Text != "   Pause")
                Assert.Fail();
            MethodInfo MethodExit = cooperativ.GetType().GetMethod("Exit", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodExit.Invoke(cooperativ, new object[] { });
            if (cooperativ.IsAccessible != false)
                Assert.Fail();
        }
        //5
        [TestMethod]
        public void Coopertiv_Open_Stop_Window_From_MenuForm()
        {
            
               var cooperativ = new CoopForm();
            MethodInfo MethodbuttonStart_Click = cooperativ.GetType().GetMethod("buttonStart_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonStart_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStart.Text != "   Pause")
                Assert.Fail();
            MethodInfo MethodbuttonStop_Click = cooperativ.GetType().GetMethod("buttonStop_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonStop_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStop.IsAccessible)
                Assert.Fail();
            MethodInfo MethodExit = cooperativ.GetType().GetMethod("Exit", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodExit.Invoke(cooperativ, new object[] { });
            if (cooperativ.IsAccessible != false)
                Assert.Fail();
        }
        //6
        [TestMethod]
        public void Coopertiv_Open_Stop_AddPlayer_Window_From_MenuForm()
        {

            var cooperativ = new CoopForm();
            MethodInfo MethodbuttonStart_Click = cooperativ.GetType().GetMethod("buttonStart_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonStart_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStart.Text != "   Pause")
                Assert.Fail();
            MethodInfo MethodbuttonStop_Click = cooperativ.GetType().GetMethod("buttonStop_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonStop_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStop.IsAccessible)
                Assert.Fail();
            MethodInfo MethodbuttonNewPlayer_Click = cooperativ.GetType().GetMethod("buttonNewPlayer_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonNewPlayer_Click.Invoke(cooperativ, new object[] { null, null });
            MethodInfo MethodExit = cooperativ.GetType().GetMethod("Exit", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodExit.Invoke(cooperativ, new object[] { });
            if (cooperativ.IsAccessible != false)
                Assert.Fail();
        }
        //7
        [TestMethod]
        public void Coopertiv_Open_Stop_AddPlayer_Clear_Close_Window_From_MenuForm()
        {

            var cooperativ = new CoopForm();
            MethodInfo MethodbuttonStart_Click = cooperativ.GetType().GetMethod("buttonStart_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonStart_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStart.Text != "   Pause")
                Assert.Fail();
            MethodInfo MethodbuttonStop_Click = cooperativ.GetType().GetMethod("buttonStop_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonStop_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStop.IsAccessible)
                Assert.Fail();
            MethodInfo MethodbuttonNewPlayer_Click = cooperativ.GetType().GetMethod("buttonNewPlayer_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonNewPlayer_Click.Invoke(cooperativ, new object[] { null, null });
            MethodInfo MethodbuttonClear_Click = cooperativ.GetType().GetMethod("buttonClear_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonClear_Click.Invoke(cooperativ, new object[] { null, null });
            MethodInfo MethodExit = cooperativ.GetType().GetMethod("Exit", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodExit.Invoke(cooperativ, new object[] { });
            if (cooperativ.IsAccessible != false)
                Assert.Fail();
        }
        //8
        [TestMethod]
        public void Coopertiv_Open_Stop_AddPlayer_Clear_Start_Close_Window_From_MenuForm()
        {

            var cooperativ = new CoopForm();
            MethodInfo MethodbuttonStart_Click = cooperativ.GetType().GetMethod("buttonStart_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonStart_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStart.Text != "   Pause")
                Assert.Fail();
            MethodInfo MethodbuttonStop_Click = cooperativ.GetType().GetMethod("buttonStop_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonStop_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStop.IsAccessible)
                Assert.Fail();
            MethodInfo MethodbuttonNewPlayer_Click = cooperativ.GetType().GetMethod("buttonNewPlayer_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonNewPlayer_Click.Invoke(cooperativ, new object[] { null, null });
            MethodInfo MethodbuttonClear_Click = cooperativ.GetType().GetMethod("buttonClear_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonClear_Click.Invoke(cooperativ, new object[] { null, null });
            MethodbuttonStart_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStart.Text != "   Pause")
                Assert.Fail();
            MethodInfo MethodExit = cooperativ.GetType().GetMethod("Exit", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodExit.Invoke(cooperativ, new object[] { });
            if (cooperativ.IsAccessible != false)
                Assert.Fail();
        }
        //9
        [TestMethod]
        public void Coopertiv_Open_Stop_AddPlayer_Clear_RemovePlayer_Start_Close_Window_From_MenuForm()
        {
            var cooperativ = new CoopForm();
            MethodInfo MethodbuttonStart_Click = cooperativ.GetType().GetMethod("buttonStart_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonStart_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStart.Text != "   Pause")
                Assert.Fail();
            MethodInfo MethodbuttonStop_Click = cooperativ.GetType().GetMethod("buttonStop_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonStop_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStop.IsAccessible)
                Assert.Fail();
            MethodInfo MethodbuttonNewPlayer_Click = cooperativ.GetType().GetMethod("buttonNewPlayer_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonNewPlayer_Click.Invoke(cooperativ, new object[] { null, null });
            MethodInfo MethodbuttonClear_Click = cooperativ.GetType().GetMethod("buttonClear_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonClear_Click.Invoke(cooperativ, new object[] { null, null });
            MethodInfo MethodrmvLine = cooperativ.GetType().GetMethod("rmvLine", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodrmvLine.Invoke(cooperativ, new object[] { cooperativ.richTextBoxMaterials, 1 });
            MethodbuttonStart_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStart.Text != "   Pause")
                Assert.Fail();
            MethodInfo MethodExit = cooperativ.GetType().GetMethod("Exit", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodExit.Invoke(cooperativ, new object[] { });
            if (cooperativ.IsAccessible != false)
                Assert.Fail();
        }
        //10
        [TestMethod]
        public void Coopertiv_Open_Stop_AddPlayer_Clear_RemovePlayer_Start_Stop_Close_Window_From_MenuForm()
        {
            var cooperativ = new CoopForm();
            MethodInfo MethodbuttonStart_Click = cooperativ.GetType().GetMethod("buttonStart_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonStart_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStart.Text != "   Pause")
                Assert.Fail();
            MethodInfo MethodbuttonStop_Click = cooperativ.GetType().GetMethod("buttonStop_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonStop_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStop.IsAccessible)
                Assert.Fail();
            MethodInfo MethodbuttonNewPlayer_Click = cooperativ.GetType().GetMethod("buttonNewPlayer_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonNewPlayer_Click.Invoke(cooperativ, new object[] { null, null });
            MethodInfo MethodbuttonClear_Click = cooperativ.GetType().GetMethod("buttonClear_Click", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodbuttonClear_Click.Invoke(cooperativ, new object[] { null, null });
            MethodInfo MethodrmvLine = cooperativ.GetType().GetMethod("rmvLine", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodrmvLine.Invoke(cooperativ, new object[] { cooperativ.richTextBoxMaterials, 1 });
            MethodbuttonStart_Click.Invoke(cooperativ, new object[] { null, null });
            if (cooperativ.buttonStart.Text != "   Pause")
                Assert.Fail();
            MethodbuttonStop_Click.Invoke(cooperativ, new object[] { null, null });
            MethodInfo MethodExit = cooperativ.GetType().GetMethod("Exit", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodExit.Invoke(cooperativ, new object[] { });
            if (cooperativ.IsAccessible != false)
                Assert.Fail();
        }
    }
}
