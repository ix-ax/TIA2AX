using tia2axTestHelper;
using NUnit.Framework;
using System.IO;
using Tia2Ax.Services;
using Tia2Ax.Interfaces;

namespace tia2axIntegrationTests
{
    public class Integration
    {
        internal static string SourcePath { get; private set; }
        internal static string TestFolderPath { get; private set; }
        internal static DirectoryInfo expectedDir { get; private set; }
        internal static DirectoryInfo generatedDir { get; private set; }
        internal static DirectoryInfo workDir { get; private set; }
        internal static TraceWriter traceWriter { get; private set; }
        internal static ApiWrapper apiWrapper { get; private set; }
        internal static Tia2AxServices creator { get; private set; }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            TestsCommon.OneTimeSetup();
            SourcePath = TestsCommon.SourcePath;
            TestFolderPath = TestsCommon.TestFolderPath;
            expectedDir = TestsCommon.expectedDir;
            generatedDir = TestsCommon.generatedDir;
            workDir = TestsCommon.workDir;

            traceWriter = new TraceWriter();
            apiWrapper = new ApiWrapper(traceWriter);
            creator = new Tia2AxServices(traceWriter, apiWrapper);
        }

        [SetUp]
        public void Setup()
        {
            TestsCommon.Setup();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            creator.CloseTiaPortal();
            TestsCommon.OneTimeTearDown();
        }

        [TearDown]
        public void TearDown()
        {
            creator.CloseTiaPortal();
        }

        [Test, Order(101)]
        public void HW_1516()
        {
            string TestCaseFolder = "HW_1516";
            TestRun(TestCaseFolder);
        }

        [Test, Order(102)]
        public void HW_1516_reader()
        {
            string TestCaseFolder = "HW_1516_reader";
            TestRun(TestCaseFolder);
        }

        [Test, Order(103)]
        public void HW_2000482_V18()
        {
            string TestCaseFolder = "HW_2000482_V18";
            TestRun(TestCaseFolder);
        }

        [Test, Order(104)]
        public void HW_2000528_main_V18()
        {
            string TestCaseFolder = "HW_2000528_main_V18";
            TestRun(TestCaseFolder);
        }

        [Test, Order(105)]
        public void HW_2000528_ST43_V18()
        {
            string TestCaseFolder = "HW_2000528_ST43_V18";
            TestRun(TestCaseFolder);
        }

        [Test, Order(106)]
        public void HW_2100068_montaz_menica_PSA_8HP_EL58_V18()
        {
            string TestCaseFolder = "HW_2100068_montaz_menica_PSA_8HP_EL58_V18";
            TestRun(TestCaseFolder);
        }

        [Test, Order(107)]
        public void HW_2200220OffsetBodu_V18()
        {
            string TestCaseFolder = "HW_2200220OffsetBodu_V18";
            TestRun(TestCaseFolder);
        }

        [Test, Order(108)]
        public void HW_2200330_V18()
        {
            string TestCaseFolder = "HW_2200330_V18";
            TestRun(TestCaseFolder);
        }

        [Test, Order(109)]
        public void HW_DiscoverGroups()
        {
            string TestCaseFolder = "HW_DiscoverGroups";
            TestRun(TestCaseFolder);
        }

        [Test, Order(110)]
        public void HW_Shared()
        {
            string TestCaseFolder = "HW_Shared";
            TestRun(TestCaseFolder);
        }


        internal static void TestRun(string testCaseFolder)
        {
            CopyTestFiles(testCaseFolder);

            string tiaProjectPath = Path.Combine(workDir.FullName, testCaseFolder + ".ap18");
            string exportPath = generatedDir.FullName;

            creator.OpenProject(tiaProjectPath);
            creator.GetPlcList(exportPath);

            Assert.IsTrue(TestsCommon.AllFilesAreEqual(expectedDir.FullName, generatedDir.FullName));

            creator.CloseProject();
        }

        private static void CopyTestFiles(string testCaseFolder)
        {
            TestsCommon.CopyFilesRecursively(Path.Combine(SourcePath,testCaseFolder), workDir.FullName);
            TestsCommon.CopyFilesRecursively(Path.Combine(TestFolderPath,"expected",testCaseFolder), expectedDir.FullName);
        }
    }
}