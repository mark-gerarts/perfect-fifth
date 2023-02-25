namespace P5

module Shape =

    open Fable.Core
    open P5.Core

    // TODO: point with vector

    [<Emit("$0.point($1, $2)")>]
    let point2D (p5: P5) (x: float) (y: float) = jsNative

    [<Emit("$0.point($1, $2)")>]
    let point3D (p5: P5) (x: float) (y: float) (z: float) = jsNative

    [<Emit("$0.line($1, $2, $3, $4)")>]
    let line2D (p5: P5) (x1: float) (y1: float) (x2: float) (y2: float) = jsNative

    [<Emit("$0.line($1, $2, $3, $4, $5, $6)")>]
    let line3D (p5: P5) (x1: float) (y1: float) (z1: float) (x2: float) (y2: float) (z2: float) = jsNative

    // TODO: BorderRadius for roundedRect.

    [<Emit("$0.rect($1, $2, $3, $4)")>]
    let rect (p5: P5) (x: float) (y: float) (w: float) (h: float) = jsNative
