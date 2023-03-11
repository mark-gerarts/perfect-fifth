namespace P5

module Transform =

    open Fable.Core
    open P5.Core

    /// TODO: axis
    [<Emit("$0.rotate($1)")>]
    let rotate (p5: P5) (angle: float) : Unit = jsNative

    // TODO: z
    // TODO: vector alternative
    [<Emit("$0.translate($1, $2)")>]
    let translate (p5: P5) (x: float) (y: float) : Unit = jsNative
