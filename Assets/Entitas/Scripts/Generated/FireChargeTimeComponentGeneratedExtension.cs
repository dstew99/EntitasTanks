//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public FireChargeTimeComponent fireChargeTime { get { return (FireChargeTimeComponent)GetComponent(ComponentIds.FireChargeTime); } }

        public bool hasFireChargeTime { get { return HasComponent(ComponentIds.FireChargeTime); } }

        public Entity AddFireChargeTime(float newValue) {
            var component = CreateComponent<FireChargeTimeComponent>(ComponentIds.FireChargeTime);
            component.value = newValue;
            return AddComponent(ComponentIds.FireChargeTime, component);
        }

        public Entity ReplaceFireChargeTime(float newValue) {
            var component = CreateComponent<FireChargeTimeComponent>(ComponentIds.FireChargeTime);
            component.value = newValue;
            ReplaceComponent(ComponentIds.FireChargeTime, component);
            return this;
        }

        public Entity RemoveFireChargeTime() {
            return RemoveComponent(ComponentIds.FireChargeTime);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherFireChargeTime;

        public static IMatcher FireChargeTime {
            get {
                if (_matcherFireChargeTime == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.FireChargeTime);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherFireChargeTime = matcher;
                }

                return _matcherFireChargeTime;
            }
        }
    }
}
