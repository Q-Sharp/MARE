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
            A.CallTo(() => RegKeyFake.GetSubKeyNames()).Returns(new string[] { "1" });
            A.CallTo(() => RegKeyFake.GetValue("KMD_EnableInternalLargePage", null)).Returns(0);
            A.CallTo(() => RegKeyFake.GetValue("EnableCrossFireAutoLink", null)).Returns(0);
            A.CallTo(() => RegKeyFake.GetValue("EnableUlps", null)).Returns(0);
            A.CallTo(() => RegKeyFake.GetValue("DriverDesc", null)).Returns("FAKE_GPU");
            A.CallTo(() => RegKeyFake.SetValue(A<string>.Ignored, A<object>.Ignored, A<RegistryValueKind>.Ignored)).DoesNothing();
            A.CallTo(() => RegKeyFake.OpenSubKey(A<string>.Ignored, A<bool>.Ignored)).Returns(RegKeyFake);

            RegFake = A.Fake<IRegistry>();
            A.CallTo(() => RegFake.OpenSubKey(A<string>.Ignored)).Returns(RegKeyFake);

            MsgBoxFake = A.Fake<IMessageBox>();
            A.CallTo(() => MsgBoxFake.Show(A<string>.Ignored)).DoesNothing();
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
            A.CallTo(() => RegKeyFake.GetValue("KMD_EnableInternalLargePage", null)).MustHaveHappened();
            A.CallTo(() => RegKeyFake.GetValue("EnableCrossFireAutoLink", null)).MustHaveHappened();
            A.CallTo(() => RegKeyFake.GetValue("EnableUlps", null)).MustHaveHappened();
            A.CallTo(() => RegKeyFake.GetValue("DriverDesc", null)).MustHaveHappened();
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
