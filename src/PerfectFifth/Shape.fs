namespace P5

module Shape =

    open Fable.Core
    open P5.Core

    [<Emit("0.smooth()")>]
    let smooth (p5: P5) : Unit = jsNative

    [<Emit("$0.noSmooth()")>]
    let noSmooth (p5: P5) : Unit = jsNative

    // TODO: point with vector

    [<Emit("$0.point($1, $2)")>]
    let point2D (p5: P5) (x: float) (y: float) : Unit = jsNative

    [<Emit("$0.point($1, $2)")>]
    let point3D (p5: P5) (x: float) (y: float) (z: float) : Unit = jsNative

    [<Emit("$0.line($1, $2, $3, $4)")>]
    let line2D (p5: P5) (x1: float) (y1: float) (x2: float) (y2: float) : Unit = jsNative

    [<Emit("$0.line($1, $2, $3, $4, $5, $6)")>]
    let line3D (p5: P5) (x1: float) (y1: float) (z1: float) (x2: float) (y2: float) (z2: float) : Unit = jsNative

    // TODO: BorderRadius for roundedRect.

    [<Emit("$0.rect($1, $2, $3, $4)")>]
    let rect (p5: P5) (x: float) (y: float) (w: float) (h: float) : Unit = jsNative
