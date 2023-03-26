namespace P5

module Transform =

    open Fable.Core
    open P5.Core

    /// TODO: axis
    [<Emit("$0.rotate($1)")>]
    let rotate (p5: P5) (angle: float) : Unit = jsNative

    [<Emit("$0.rotateX($1)")>]
    let rotateX (p5: P5) (angle: float) : Unit = jsNative

    [<Emit("$0.rotateY($1)")>]
    let rotateY (p5: P5) (angle: float) : Unit = jsNative

    [<Emit("$0.rotateZ($1)")>]
    let rotateZ (p5: P5) (angle: float) : Unit = jsNative

    // TODO: vector alternative
    [<Emit("$0.translate($1, $2)")>]
    let translate (p5: P5) (x: float) (y: float) : Unit = jsNative

    // TODO: vector alternative
    [<Emit("$0.translate($1, $2, $3)")>]
    let translateZ (p5: P5) (x: float) (y: float) (z: float) : Unit = jsNative

    let translate3D = translateZ

    /// TODO: y, z, scales
    [<Emit("$0.scale($1)")>]
    let scale (p5: P5) (s: float) : Unit = jsNative
