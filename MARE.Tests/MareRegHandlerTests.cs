using Xunit;
using FakeItEasy;
using Microsoft.Win32;

namespace MARE.Tests
{
    public class MareRegHandlerTests
    {
        private readonly IMessageBox MsgBoxFake;
        private readonly IRegistry RegFake;
        private readonly IRegistryKey RegKeyFake;

        public MareRegHandlerTests()
        {
            RegKeyFake = A.Fake<IRegistryKey>();
            A.CallTo(() => RegKeyFake.GetSubKeyNames()).Returns(new string[] { "Key" });
            A.CallTo(() => RegKeyFake.GetValue("KMD_EnableInternalLargePage", null)).Returns(0);
            A.CallTo(() => RegKeyFake.GetValue("EnableCrossFireAutoLink", null)).Returns(0);
            A.CallTo(() => RegKeyFake.GetValue("EnableUlps", null)).Returns(0);
            A.CallTo(() => RegKeyFake.GetValue("DriverDesc", null)).Returns("FAKE_GPU");
            A.CallTo(() => RegKeyFake.SetValue(A.Dummy<string>(), A.Dummy<object>(), A.Dummy<RegistryValueKind>())).DoesNothing();

            RegFake = A.Fake<IRegistry>();
            A.CallTo(() => RegFake.OpenSubKey(A.Dummy<string>())).Returns(RegKeyFake);

            MsgBoxFake = A.Fake<IMessageBox>();
            A.CallTo(() => MsgBoxFake.Show(A.Dummy<string>())).DoesNothing();
        }

        [Fact]
        public void MareRegHandlerTest()
        {
            var oMareRegHandler = new MareRegHandler(RegFake, MsgBoxFake);
            Assert.Empty(oMareRegHandler.AllGFX);
        }

        [Fact]
        public void LoadRegTest()
        {
            var oMareRegHandler = new MareRegHandler(RegFake, MsgBoxFake);
            oMareRegHandler.LoadReg();

            A.CallTo(() => RegFake.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}")).MustHaveHappened();
            A.CallTo(() => RegKeyFake.GetValue(A<string>._, A<object>._)).MustHaveHappenedTwiceOrMore();
            Assert.Collection(oMareRegHandler.AllGFX, x => new GFX(0, 0, 0, 0, "FAKE_GPU"));
        }

        [Fact]
        public void UpdateTest()
        {
            var oMareRegHandler = new MareRegHandler(RegFake, MsgBoxFake);

            oMareRegHandler.AllGFX.Add(new GFX(0, 0, 0, 0, "FAKE_GPU"));

            oMareRegHandler.Update(0, "FAKE_GPU", 1, 1, 1);

            Assert.Collection(oMareRegHandler.AllGFX, x => new GFX(0, 1, 1, 1, "FAKE_GPU"));
            
        }

        [Fact]
        public void SaveRegTest()
        {
            var oMareRegHandler = new MareRegHandler(RegFake, MsgBoxFake);
            oMareRegHandler.SaveReg();

            A.CallTo(() => RegFake.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}")).MustHaveHappened();
        }
    }
}
