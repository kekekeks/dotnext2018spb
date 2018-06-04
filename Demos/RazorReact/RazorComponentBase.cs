using System;
using Bridge;
using Bridge.React;

namespace RazorReact
{
    public abstract class RazorComponentBase<TProps, TState> : Bridge.Razor.React.RazorComponent<TProps, TState>
        where TState: class, new()
    {
        protected RazorComponentBase():base(default(TProps))
        {
            throw new Exception("Don't use");
        }
        
        protected RazorComponentBase(TProps props, params Union<ReactElement, string>[] children) : base(props, children)
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