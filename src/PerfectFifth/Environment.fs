namespace P5

module Environment =

    open Fable.Core
    open P5.Core

    [<Emit("$0.width")>]
    let width (p5: P5) : int = jsNative

    [<Emit("$0.height")>]
    let height (p5: P5) : int = jsNative
