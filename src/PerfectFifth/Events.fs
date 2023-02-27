namespace P5

module Events =

    open Fable.Core
    open P5.Core

    [<Emit("$0.mouseX")>]
    let mouseX (p5: P5) : int = jsNative

    [<Emit("$0.mouseY")>]
    let mouseY (p5: P5) : int = jsNative
