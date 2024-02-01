//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputContext {

    public InputEntity logPositionEntity { get { return GetGroup(InputMatcher.LogPosition).GetSingleEntity(); } }

    public bool isLogPosition {
        get { return logPositionEntity != null; }
        set {
            var entity = logPositionEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isLogPosition = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    static readonly LogPositionComponent logPositionComponent = new LogPositionComponent();

    public bool isLogPosition {
        get { return HasComponent(InputComponentsLookup.LogPosition); }
        set {
            if (value != isLogPosition) {
                var index = InputComponentsLookup.LogPosition;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : logPositionComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherLogPosition;

    public static Entitas.IMatcher<InputEntity> LogPosition {
        get {
            if (_matcherLogPosition == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.LogPosition);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherLogPosition = matcher;
            }

            return _matcherLogPosition;
        }
    }
}