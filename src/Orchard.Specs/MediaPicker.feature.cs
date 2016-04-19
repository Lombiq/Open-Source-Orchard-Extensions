﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Orchard.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Media Picker Field")]
    public partial class MediaPickerFieldFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MediaPicker.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Media Picker Field", "  In order to add a media content to my types\r\n  As an administrator\r\n  I want to" +
                    " create, edit and publish media fields", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Creating and using media fields")]
        public virtual void CreatingAndUsingMediaFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating and using media fields", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 9
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
        testRunner.And("I have installed \"Orchard.Media\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
        testRunner.And("I have installed \"Orchard.MediaPicker\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
    testRunner.When("I go to \"Admin/ContentTypes\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
    testRunner.Then("I should see \"<a[^>]*>.*?Create new type</a>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
    testRunner.When("I go to \"Admin/ContentTypes/Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table1.AddRow(new string[] {
                        "DisplayName",
                        "Event"});
            table1.AddRow(new string[] {
                        "Name",
                        "Event"});
#line 16
        testRunner.And("I fill in", ((string)(null)), table1, "And ");
#line 20
        testRunner.And("I hit \"Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
        testRunner.And("I go to \"Admin/ContentTypes/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
    testRunner.Then("I should see \"Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
        testRunner.And("I follow \"Add Field\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table2.AddRow(new string[] {
                        "DisplayName",
                        "File"});
            table2.AddRow(new string[] {
                        "Name",
                        "File"});
            table2.AddRow(new string[] {
                        "FieldTypeName",
                        "MediaPickerField"});
#line 27
        testRunner.And("I fill in", ((string)(null)), table2, "And ");
#line 32
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
    testRunner.Then("I should see \"The \\\"File\\\" field has been added.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
    testRunner.When("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
    testRunner.Then("I should see \"File\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table3.AddRow(new string[] {
                        "Event.File.Url",
                        ""});
#line 39
    testRunner.When("I fill in", ((string)(null)), table3, "When ");
#line 42
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
    testRunner.Then("I should see \"Your Event has been created.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table4.AddRow(new string[] {
                        "Fields[0].MediaPickerFieldSettings.Hint",
                        "Please select a file"});
#line 48
        testRunner.And("I fill in", ((string)(null)), table4, "And ");
#line 51
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
    testRunner.Then("I should see \"Please select a file\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table5.AddRow(new string[] {
                        "Fields[0].MediaPickerFieldSettings.Required",
                        "true"});
#line 57
        testRunner.And("I fill in", ((string)(null)), table5, "And ");
#line 60
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table6.AddRow(new string[] {
                        "Event.File.Url",
                        ""});
#line 62
        testRunner.And("I fill in", ((string)(null)), table6, "And ");
#line 65
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
    testRunner.Then("I should see \"The field File is mandatory.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table7.AddRow(new string[] {
                        "ext-Fields[0].MediaPickerFieldSettings",
                        "true"});
            table7.AddRow(new string[] {
                        "Fields[0].MediaPickerFieldSettings.AllowedExtensions",
                        "jpg"});
#line 70
        testRunner.And("I fill in", ((string)(null)), table7, "And ");
#line 74
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table8.AddRow(new string[] {
                        "Event.File.Url",
                        "~/Media/Default/images/Image.png"});
#line 76
    testRunner.And("I fill in", ((string)(null)), table8, "And ");
#line 79
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
    testRunner.Then("I should see \"The field File must have one of these extensions: jpg\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
