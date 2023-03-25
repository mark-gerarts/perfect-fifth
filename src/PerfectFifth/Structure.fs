namespace P5

module Structure =

    open Fable.Core
    open P5.Core

    [<Emit("$0.remove()")>]
    let remove (p5: P5) : Unit = jsNative

    [<Emit("$0.loop()")>]
    let loop (p5: P5) : Unit = jsNative

    /// Redraws the sketch. Be wary when calling this in an eventHandler,
    /// because the state returned from the event handler is the final one, even
    /// though calling redraw implicitly calls update as well.
    [<Emit("$0.redraw()")>]
    let redraw (p5: P5) : Unit = jsNative

    /// Same as redraw, but do it N times. Heed the warning of redraw.
    [<Emit("$0.redraw($1)")>]
    let redrawNTimes (p5: P5) (n: int) : Unit = jsNative
