namespace P5

module Transform =

    open Fable.Core
    open P5.Core

    // TODO: z
    // TODO: vector alternative
    [<Emit("$0.translate($1, $2)")>]
    let translate (p5: P5) (x: float) (y: float) : Unit = jsNative
