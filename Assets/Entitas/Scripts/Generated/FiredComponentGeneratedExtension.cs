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
        static readonly FiredComponent firedComponent = new FiredComponent();

        public bool isFired {
            get { return HasComponent(ComponentIds.Fired); }
            set {
                if (value != isFired) {
                    if (value) {
                        AddComponent(ComponentIds.Fired, firedComponent);
                    } else {
                        RemoveComponent(ComponentIds.Fired);
                    }
                }
            }
        }

        public Entity IsFired(bool value) {
            isFired = value;
            return this;
        }
    }

    public partial class Matcher {
        static IMatcher _matcherFired;

        public static IMatcher Fired {
            get {
                if (_matcherFired == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Fired);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherFired = matcher;
                }

                return _matcherFired;
            }
        }
    }
}