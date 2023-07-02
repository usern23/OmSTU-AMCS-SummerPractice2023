﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace bdd.Tests
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class НахождениеКорнейFeature : object, Xunit.IClassFixture<НахождениеКорнейFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "test.feature"
#line hidden
        
        public НахождениеКорнейFeature(НахождениеКорнейFeature.FixtureData fixtureData, bdd_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("ru"), "", "Нахождение корней", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Если дискриминант квадратного уравнения больше 0, то квадратное уравнение имеет д" +
            "ва корня кратности 1")]
        [Xunit.TraitAttribute("FeatureTitle", "Нахождение корней")]
        [Xunit.TraitAttribute("Description", "Если дискриминант квадратного уравнения больше 0, то квадратное уравнение имеет д" +
            "ва корня кратности 1")]
        public void ЕслиДискриминантКвадратногоУравненияБольше0ТоКвадратноеУравнениеИмеетДваКорняКратности1()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Если дискриминант квадратного уравнения больше 0, то квадратное уравнение имеет д" +
                    "ва корня кратности 1", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 3
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
    testRunner.Given("Квадратное уравнение с коэффициентами (1, 0, -1)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 5
    testRunner.When("вычисляются корни квадратного уравнения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 6
    testRunner.Then("квадратное уравнение имеет два корня (1, -1) кратности один", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Если дискриминант квадратного уравнения равен 0, то квадратное уравнение имеет од" +
            "ин корень кратности 2")]
        [Xunit.TraitAttribute("FeatureTitle", "Нахождение корней")]
        [Xunit.TraitAttribute("Description", "Если дискриминант квадратного уравнения равен 0, то квадратное уравнение имеет од" +
            "ин корень кратности 2")]
        public void ЕслиДискриминантКвадратногоУравненияРавен0ТоКвадратноеУравнениеИмеетОдинКореньКратности2()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Если дискриминант квадратного уравнения равен 0, то квадратное уравнение имеет од" +
                    "ин корень кратности 2", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 9
    testRunner.Given("Квадратное уравнение с коэффициентами (1, -2, 1)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 10
    testRunner.When("вычисляются корни квадратного уравнения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 11
    testRunner.Then("квадратное уравнение имеет один корень 1 кратности два", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Если дискриминант квадратного уравнения меньше 0, то квадратное уравнение не имее" +
            "т корней")]
        [Xunit.TraitAttribute("FeatureTitle", "Нахождение корней")]
        [Xunit.TraitAttribute("Description", "Если дискриминант квадратного уравнения меньше 0, то квадратное уравнение не имее" +
            "т корней")]
        public void ЕслиДискриминантКвадратногоУравненияМеньше0ТоКвадратноеУравнениеНеИмеетКорней()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Если дискриминант квадратного уравнения меньше 0, то квадратное уравнение не имее" +
                    "т корней", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 13
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 14
    testRunner.Given("Квадратное уравнение с коэффициентами (1, 0, 1)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 15
    testRunner.When("вычисляются корни квадратного уравнения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 16
    testRunner.Then("множество корней квадратного уравнения пустое", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Коэффициент a квадратного уравнения не может быть равен 0")]
        [Xunit.TraitAttribute("FeatureTitle", "Нахождение корней")]
        [Xunit.TraitAttribute("Description", "Коэффициент a квадратного уравнения не может быть равен 0")]
        public void КоэффициентAКвадратногоУравненияНеМожетБытьРавен0()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Коэффициент a квадратного уравнения не может быть равен 0", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 18
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 19
    testRunner.Given("Квадратное уравнение с коэффициентами (1e-7, 0, 1)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 20
    testRunner.When("вычисляются корни квадратного уравнения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 21
    testRunner.Then("выбрасывается исключение ArgumentException", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Коэффициент a квадратного уравнение не может быть не числом")]
        [Xunit.TraitAttribute("FeatureTitle", "Нахождение корней")]
        [Xunit.TraitAttribute("Description", "Коэффициент a квадратного уравнение не может быть не числом")]
        public void КоэффициентAКвадратногоУравнениеНеМожетБытьНеЧислом()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Коэффициент a квадратного уравнение не может быть не числом", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 23
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 24
    testRunner.Given("Квадратное уравнение с коэффициентами (NaN, 0, 1)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 25
    testRunner.When("вычисляются корни квадратного уравнения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 26
    testRunner.Then("выбрасывается исключение ArgumentException", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Коэффициент a квадратного уравнение не может быть положительной бесконечностью")]
        [Xunit.TraitAttribute("FeatureTitle", "Нахождение корней")]
        [Xunit.TraitAttribute("Description", "Коэффициент a квадратного уравнение не может быть положительной бесконечностью")]
        public void КоэффициентAКвадратногоУравнениеНеМожетБытьПоложительнойБесконечностью()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Коэффициент a квадратного уравнение не может быть положительной бесконечностью", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 28
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 29
    testRunner.Given("Квадратное уравнение с коэффициентами (Double.PositiveInfinity, 0, 1)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 30
    testRunner.When("вычисляются корни квадратного уравнения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 31
    testRunner.Then("выбрасывается исключение ArgumentException", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Коэффициент a квадратного уравнение не может быть отрицательной бесконечностью")]
        [Xunit.TraitAttribute("FeatureTitle", "Нахождение корней")]
        [Xunit.TraitAttribute("Description", "Коэффициент a квадратного уравнение не может быть отрицательной бесконечностью")]
        public void КоэффициентAКвадратногоУравнениеНеМожетБытьОтрицательнойБесконечностью()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Коэффициент a квадратного уравнение не может быть отрицательной бесконечностью", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 34
    testRunner.Given("Квадратное уравнение с коэффициентами (Double.NegativeInfinity, 0, 1)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 35
    testRunner.When("вычисляются корни квадратного уравнения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 36
    testRunner.Then("выбрасывается исключение ArgumentException", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Коэффициент b квадратного уравнение не может быть не числом")]
        [Xunit.TraitAttribute("FeatureTitle", "Нахождение корней")]
        [Xunit.TraitAttribute("Description", "Коэффициент b квадратного уравнение не может быть не числом")]
        public void КоэффициентBКвадратногоУравнениеНеМожетБытьНеЧислом()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Коэффициент b квадратного уравнение не может быть не числом", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 38
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 39
    testRunner.Given("Квадратное уравнение с коэффициентами (1, NaN, 1)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 40
    testRunner.When("вычисляются корни квадратного уравнения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 41
    testRunner.Then("выбрасывается исключение ArgumentException", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Коэффициент b квадратного уравнение не может быть положительной бесконечностью")]
        [Xunit.TraitAttribute("FeatureTitle", "Нахождение корней")]
        [Xunit.TraitAttribute("Description", "Коэффициент b квадратного уравнение не может быть положительной бесконечностью")]
        public void КоэффициентBКвадратногоУравнениеНеМожетБытьПоложительнойБесконечностью()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Коэффициент b квадратного уравнение не может быть положительной бесконечностью", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 43
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 44
    testRunner.Given("Квадратное уравнение с коэффициентами (1, Double.PositiveInfinity, 1)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 45
    testRunner.When("вычисляются корни квадратного уравнения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 46
    testRunner.Then("выбрасывается исключение ArgumentException", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Коэффициент b квадратного уравнение не может быть отрицательной бесконечностью")]
        [Xunit.TraitAttribute("FeatureTitle", "Нахождение корней")]
        [Xunit.TraitAttribute("Description", "Коэффициент b квадратного уравнение не может быть отрицательной бесконечностью")]
        public void КоэффициентBКвадратногоУравнениеНеМожетБытьОтрицательнойБесконечностью()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Коэффициент b квадратного уравнение не может быть отрицательной бесконечностью", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 48
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 49
    testRunner.Given("Квадратное уравнение с коэффициентами (1, Double.NegativeInfinity, 1)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 50
    testRunner.When("вычисляются корни квадратного уравнения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 51
    testRunner.Then("выбрасывается исключение ArgumentException", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Коэффициент c квадратного уравнение не может быть не числом")]
        [Xunit.TraitAttribute("FeatureTitle", "Нахождение корней")]
        [Xunit.TraitAttribute("Description", "Коэффициент c квадратного уравнение не может быть не числом")]
        public void КоэффициентCКвадратногоУравнениеНеМожетБытьНеЧислом()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Коэффициент c квадратного уравнение не может быть не числом", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 53
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 54
    testRunner.Given("Квадратное уравнение с коэффициентами (1, 0, NaN)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 55
    testRunner.When("вычисляются корни квадратного уравнения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 56
    testRunner.Then("выбрасывается исключение ArgumentException", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Коэффициент c квадратного уравнение не может быть положительной бесконечностью")]
        [Xunit.TraitAttribute("FeatureTitle", "Нахождение корней")]
        [Xunit.TraitAttribute("Description", "Коэффициент c квадратного уравнение не может быть положительной бесконечностью")]
        public void КоэффициентCКвадратногоУравнениеНеМожетБытьПоложительнойБесконечностью()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Коэффициент c квадратного уравнение не может быть положительной бесконечностью", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 58
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 59
    testRunner.Given("Квадратное уравнение с коэффициентами (1, 0, Double.PositiveInfinity)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 60
    testRunner.When("вычисляются корни квадратного уравнения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 61
    testRunner.Then("выбрасывается исключение ArgumentException", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Коэффициент c квадратного уравнение не может быть отрицательной бесконечностью")]
        [Xunit.TraitAttribute("FeatureTitle", "Нахождение корней")]
        [Xunit.TraitAttribute("Description", "Коэффициент c квадратного уравнение не может быть отрицательной бесконечностью")]
        public void КоэффициентCКвадратногоУравнениеНеМожетБытьОтрицательнойБесконечностью()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Коэффициент c квадратного уравнение не может быть отрицательной бесконечностью", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 63
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 64
    testRunner.Given("Квадратное уравнение с коэффициентами (1, 0, Double.NegativeInfinity)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
#line 65
    testRunner.When("вычисляются корни квадратного уравнения", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 66
    testRunner.Then("выбрасывается исключение ArgumentException", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                НахождениеКорнейFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                НахождениеКорнейFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
