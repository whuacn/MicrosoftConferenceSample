﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.269
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.Integration.Registration
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class Self_RegistrantScenariosForMakingAReservationForAConferenceSiteWhereMultipleRegistrantsMakeSimultaneousReservationsFeature : Xunit.IUseFixture<Self_RegistrantScenariosForMakingAReservationForAConferenceSiteWhereMultipleRegistrantsMakeSimultaneousReservationsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SelfRegistrationReservationWithConcurrencyIntegration.feature"
#line hidden
        
        public Self_RegistrantScenariosForMakingAReservationForAConferenceSiteWhereMultipleRegistrantsMakeSimultaneousReservationsFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Self-Registrant scenarios for making a Reservation for a Conference site where mu" +
                    "ltiple Registrants make simultaneous reservations", "In order to reserve Seats for a Conference\r\nAs an Attendee\r\nI want to be able to " +
                    "select an Order Item from one or many of the available where other Registrants m" +
                    "ay also be interested", ProgrammingLanguage.CSharp, new string[] {
                        "NoWatiN"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(Self_RegistrantScenariosForMakingAReservationForAConferenceSiteWhereMultipleRegistrantsMakeSimultaneousReservationsFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Self-Registrant scenarios for making a Reservation for a Conference site where mu" +
            "ltiple Registrants make simultaneous reservations")]
        [Xunit.TraitAttribute("Description", "Some Registrants try to reserve the same Order Item and not all of them get the r" +
            "eservation")]
        public virtual void SomeRegistrantsTryToReserveTheSameOrderItemAndNotAllOfThemGetTheReservation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Some Registrants try to reserve the same Order Item and not all of them get the r" +
                    "eservation", new string[] {
                        "SelfRegistrationReservationWithConcurrencyIntegration"});
#line 22
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "rate",
                        "quota"});
            table1.AddRow(new string[] {
                        "CQRS Workshop",
                        "$500",
                        "4"});
#line 23
 testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table2.AddRow(new string[] {
                        "CQRS Workshop",
                        "2"});
#line 26
 testRunner.When("4 Registrants select these Order Items", ((string)(null)), table2);
#line 30
 testRunner.Then("only 2 events for completing the Order reservation are emitted");
#line 32
 testRunner.And("2 events for partially completing the order are emitted");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Self-Registrant scenarios for making a Reservation for a Conference site where mu" +
            "ltiple Registrants make simultaneous reservations")]
        [Xunit.TraitAttribute("Description", "Many Registrants try to reserve the same Order Item and not all of them get the r" +
            "eservation")]
        public virtual void ManyRegistrantsTryToReserveTheSameOrderItemAndNotAllOfThemGetTheReservation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Many Registrants try to reserve the same Order Item and not all of them get the r" +
                    "eservation", new string[] {
                        "SelfRegistrationReservationWithConcurrencyIntegrationDebugLocalOnly"});
#line 38
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "rate",
                        "quota"});
            table3.AddRow(new string[] {
                        "CQRS Workshop",
                        "$500",
                        "200"});
#line 39
 testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference", ((string)(null)), table3);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table4.AddRow(new string[] {
                        "CQRS Workshop",
                        "2"});
#line 42
 testRunner.When("200 Registrants select these Order Items", ((string)(null)), table4);
#line 46
 testRunner.Then("only 100 events for completing the Order reservation are emitted");
#line 48
 testRunner.And("100 events for partially completing the order are emitted");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Self-Registrant scenarios for making a Reservation for a Conference site where mu" +
            "ltiple Registrants make simultaneous reservations")]
        [Xunit.TraitAttribute("Description", "Many Registrants try to reserve many of the same Order Items and some of them get" +
            " a partial reservation")]
        public virtual void ManyRegistrantsTryToReserveManyOfTheSameOrderItemsAndSomeOfThemGetAPartialReservation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Many Registrants try to reserve many of the same Order Items and some of them get" +
                    " a partial reservation", new string[] {
                        "SelfRegistrationReservationWithConcurrencyIntegrationDebugLocalOnly"});
#line 54
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "rate",
                        "quota"});
            table5.AddRow(new string[] {
                        "CQRS Workshop",
                        "$500",
                        "200"});
            table5.AddRow(new string[] {
                        "General admission",
                        "$199",
                        "100"});
#line 55
 testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference", ((string)(null)), table5);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table6.AddRow(new string[] {
                        "CQRS Workshop",
                        "1"});
            table6.AddRow(new string[] {
                        "General admission",
                        "2"});
#line 59
 testRunner.When("200 Registrants select these Order Items", ((string)(null)), table6);
#line 64
 testRunner.Then("only 50 events for completing the Order reservation are emitted");
#line 66
 testRunner.And("150 events for partially completing the order are emitted");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                Self_RegistrantScenariosForMakingAReservationForAConferenceSiteWhereMultipleRegistrantsMakeSimultaneousReservationsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                Self_RegistrantScenariosForMakingAReservationForAConferenceSiteWhereMultipleRegistrantsMakeSimultaneousReservationsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
