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
        public HealthComponent health { get { return (HealthComponent)GetComponent(ComponentIds.Health); } }

        public bool hasHealth { get { return HasComponent(ComponentIds.Health); } }

        public Entity AddHealth(float newValue, float newMax) {
            var component = CreateComponent<HealthComponent>(ComponentIds.Health);
            component.value = newValue;
            component.max = newMax;
            return AddComponent(ComponentIds.Health, component);
        }

        public Entity ReplaceHealth(float newValue, float newMax) {
            var component = CreateComponent<HealthComponent>(ComponentIds.Health);
            component.value = newValue;
            component.max = newMax;
            ReplaceComponent(ComponentIds.Health, component);
            return this;
        }

        public Entity RemoveHealth() {
            return RemoveComponent(ComponentIds.Health);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherHealth;

        public static IMatcher Health {
            get {
                if (_matcherHealth == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Health);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherHealth = matcher;
                }

                return _matcherHealth;
            }
        }
    }
}
