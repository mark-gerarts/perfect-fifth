namespace P5

module Shape =

    open Fable.Core
    open P5.Core

    type ArcMode =
        | Chord
        | Pie
        | Open

    let private rawArcMode mode =
        match mode with
        | Chord -> "chord"
        | Pie -> "pie"
        | Open -> "open"

    [<Emit("0.smooth()")>]
    let smooth (p5: P5) : Unit = jsNative

    [<Emit("$0.noSmooth()")>]
    let noSmooth (p5: P5) : Unit = jsNative

    [<Emit("$0.arc($1, $2, $3, $4, $5, $6)")>]
    let arc (p5: P5) (x: float) (y: float) (w: float) (h: float) (start: float) (stop: float) : Unit = jsNative

    [<Emit("$0.arc($1, $2, $3, $4, $5, $6, $7, $8)")>]
    let private arc_
        (p5: P5)
        (x: float)
        (y: float)
        (w: float)
        (h: float)
        (start: float)
        (stop: float)
        (mode: string)
        (detail: int)
        : Unit =
        jsNative

    let arcMode
        (p5: P5)
        (x: float)
        (y: float)
        (w: float)
        (h: float)
        (start: float)
        (stop: float)
        (mode: ArcMode)
        : Unit =
        arc_ p5 x y w h start stop (rawArcMode mode) 25

    let arcDetail
        (p5: P5)
        (x: float)
        (y: float)
        (w: float)
        (h: float)
        (start: float)
        (stop: float)
        (mode: ArcMode)
        (detail: int)
        : Unit =
        arc_ p5 x y w h start stop (rawArcMode mode) detail

    /// TODO: point with vector
    [<Emit("$0.point($1, $2)")>]
    let point2D (p5: P5) (x: float) (y: float) : Unit = jsNative

    let point = point2D

    [<Emit("$0.point($1, $2)")>]
    let point3D (p5: P5) (x: float) (y: float) (z: float) : Unit = jsNative

    [<Emit("$0.line($1, $2, $3, $4)")>]
    let line2D (p5: P5) (x1: float) (y1: float) (x2: float) (y2: float) : Unit = jsNative

    [<Emit("$0.line($1, $2, $3, $4, $5, $6)")>]
    let line3D (p5: P5) (x1: float) (y1: float) (z1: float) (x2: float) (y2: float) (z2: float) : Unit = jsNative

    let line = line2D

    [<Emit("$0.rect($1, $2, $3, $4)")>]
    let rect (p5: P5) (x: float) (y: float) (w: float) (h: float) : Unit = jsNative

    [<Emit("$0.rect($1, $2, $3, $4, $5, $6)")>]
    let rectDetail (p5: P5) (x: float) (y: float) (w: float) (h: float) (detailX: int) (detailY: int) : Unit = jsNative

    [<Emit("$0.rect($1, $2, $3, $4, $5, $6, $7, $8)")>]
    let roundedRect
        (p5: P5)
        (x: float)
        (y: float)
        (w: float)
        (h: float)
        (tl: float)
        (tr: float)
        (bl: float)
        (br: float)
        : Unit =
        jsNative

    [<Emit("$0.square($1, $2, $3)")>]
    let square (p5: P5) (x: float) (y: float) (s: float) : Unit = jsNative

    [<Emit("$0.square($1, $2, $3, $4, $5, $6, $7)")>]
    let roundedSquare (p5: P5) (x: float) (y: float) (s: float) (tl: float) (tr: float) (bl: float) (br: float) : Unit =
        jsNative

    [<Emit("$0.triangle($1, $2, $3, $4, $5, $6)")>]
    let triangle (p5: P5) (x1: float) (y1: float) (x2: float) (y2: float) (x3: float) (y3: float) : Unit = jsNative

    [<Emit("$0.ellipse($1, $2, $3, $4)")>]
    let ellipse (p5: P5) (x: float) (y: float) (w: float) (h: float) : Unit = jsNative

    [<Emit("$0.ellipse($1, $2, $3, $4, $5)")>]
    let ellipseDetail (p5: P5) (x: float) (y: float) (w: float) (h: float) (detail: int) : Unit = jsNative

    [<Emit("$0.circle($1, $2, $3)")>]
    let circle (p5: P5) (x: float) (y: float) (d: float) : Unit = jsNative

    [<Emit("$0.quad($1, $2, $3, $4, $5, $6, $7, $8)")>]
    let quad
        (p5: P5)
        (x1: float)
        (y1: float)
        (x2: float)
        (y2: float)
        (x3: float)
        (y3: float)
        (x4: float)
        (y4: float)
        : Unit =
        jsNative

    // quadDetail
    [<Emit("$0.quad($1, $2, $3, $4, $5, $6, $7, $8, $9, $10)")>]
    let quadDetail
        (p5: P5)
        (x1: float)
        (y1: float)
        (x2: float)
        (y2: float)
        (x3: float)
        (y3: float)
        (x4: float)
        (y4: float)
        (detailX: int)
        (detailY: int)
        : Unit =
        jsNative

    [<Emit("$0.quad($1, $2, $3, $4, $5, $6, $7, $8, $9, $10, $11, $12)")>]
    let quadZ
        (p5: P5)
        (x1: float)
        (y1: float)
        (z1: float)
        (x2: float)
        (y2: float)
        (z2: float)
        (x3: float)
        (y3: float)
        (z3: float)
        (x4: float)
        (y4: float)
        (z4: float)
        : Unit =
        jsNative

    [<Emit("$0.quad($1, $2, $3, $4, $5, $6, $7, $8, $9, $10, $11, $12, $13, $14)")>]
    let quadZDetail
        (p5: P5)
        (x1: float)
        (y1: float)
        (z1: float)
        (x2: float)
        (y2: float)
        (z2: float)
        (x3: float)
        (y3: float)
        (z3: float)
        (x4: float)
        (y4: float)
        (z4: float)
        (detailX: int)
        (detailY: int)
        : Unit =
        jsNative
