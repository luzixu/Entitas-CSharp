//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test2Entity {

    public Test2MultipleContextStandardEventListenerComponent test2MultipleContextStandardEventListener { get { return (Test2MultipleContextStandardEventListenerComponent)GetComponent(Test2ComponentsLookup.Test2MultipleContextStandardEventListener); } }
    public bool hasTest2MultipleContextStandardEventListener { get { return HasComponent(Test2ComponentsLookup.Test2MultipleContextStandardEventListener); } }

    public void AddTest2MultipleContextStandardEventListener(System.Collections.Generic.List<ITest2MultipleContextStandardEventListener> newValue) {
        var index = Test2ComponentsLookup.Test2MultipleContextStandardEventListener;
        var component = CreateComponent<Test2MultipleContextStandardEventListenerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTest2MultipleContextStandardEventListener(System.Collections.Generic.List<ITest2MultipleContextStandardEventListener> newValue) {
        var index = Test2ComponentsLookup.Test2MultipleContextStandardEventListener;
        var component = CreateComponent<Test2MultipleContextStandardEventListenerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTest2MultipleContextStandardEventListener() {
        RemoveComponent(Test2ComponentsLookup.Test2MultipleContextStandardEventListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class Test2Matcher {

    static Entitas.IMatcher<Test2Entity> _matcherTest2MultipleContextStandardEventListener;

    public static Entitas.IMatcher<Test2Entity> Test2MultipleContextStandardEventListener {
        get {
            if (_matcherTest2MultipleContextStandardEventListener == null) {
                var matcher = (Entitas.Matcher<Test2Entity>)Entitas.Matcher<Test2Entity>.AllOf(Test2ComponentsLookup.Test2MultipleContextStandardEventListener);
                matcher.componentNames = Test2ComponentsLookup.componentNames;
                _matcherTest2MultipleContextStandardEventListener = matcher;
            }

            return _matcherTest2MultipleContextStandardEventListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test2Entity {

    public void AddTest2MultipleContextStandardEventListener(ITest2MultipleContextStandardEventListener value) {
        var listeners = hasTest2MultipleContextStandardEventListener
            ? test2MultipleContextStandardEventListener.value
            : new System.Collections.Generic.List<ITest2MultipleContextStandardEventListener>();
        listeners.Add(value);
        ReplaceTest2MultipleContextStandardEventListener(listeners);
    }

    public void RemoveTest2MultipleContextStandardEventListener(ITest2MultipleContextStandardEventListener value, bool removeComponentWhenEmpty = true) {
        var listeners = test2MultipleContextStandardEventListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveTest2MultipleContextStandardEventListener();
        } else {
            ReplaceTest2MultipleContextStandardEventListener(listeners);
        }
    }
}
