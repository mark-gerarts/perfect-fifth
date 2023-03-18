namespace P5

module DOM =

    open Fable.Core
    open P5.Core

    type P5Element =
        [<Emit("$0.center()")>]
        member _.center() : Unit = jsNative

        [<Emit("$0.center($1)")>]
        member _.centerWithAlign(align: string) : Unit = jsNative

        [<Emit("$0.style($1, $2)")>]
        member _.style (property: string) (value: string) : Unit = jsNative

        member _.toString() : string = jsNative

    [<Emit("$0.createP($1)")>]
    let createP (p5: P5) (innerHTML: string) : P5Element = jsNative
