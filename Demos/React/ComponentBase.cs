using System;
using Bridge;
using Bridge.React;

namespace React
{
    public abstract class ComponentBase<TProps, TState> : Component<TProps, TState> where TState : class, new()
    {
        public ComponentBase(TProps props, params Union<ReactElement, string>[] children) : base(props, children)
        {
        }

        protected void UpdateState(Action<TState> cb)
        {
            var state = this.state ?? new TState();
            cb(state);
            SetState(state);
        }
    }
}