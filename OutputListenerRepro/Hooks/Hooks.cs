using System;
using System.Collections.Generic;
using System.Text;
using BoDi;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace OutputListenerRepro.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario(Order = 1)]
        public void RegisterDependencies(IObjectContainer objectContainer)
        {
            objectContainer.RegisterTypeAs<CustomOutputListener, ISpecFlowScenarioOutputListener>("customlistener");
        }
    }

    public class CustomOutputListener : ISpecFlowScenarioOutputListener
    {
        public void OnMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
