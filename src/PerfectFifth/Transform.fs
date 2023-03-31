namespace P5

module Transform =

    open Fable.Core
    open P5.Core
    open Math

    [<Emit("$0.rotate($1)")>]
    let rotate (p5: P5) (angle: float) : Unit = jsNative

    [<Emit("$0.rotate($1, $2)")>]
    let rotateAroundAxis (p5: P5) (angle: float) (axis: float array) : Unit = jsNative

    [<Emit("$0.rotate($1, $2)")>]
    let rotateAroundVector (p5: P5) (angle: float) (axis: P5Vector) : Unit = jsNative

    [<Emit("$0.rotateX($1)")>]
    let rotateX (p5: P5) (angle: float) : Unit = jsNative

    [<Emit("$0.rotateY($1)")>]
    let rotateY (p5: P5) (angle: float) : Unit = jsNative

    [<Emit("$0.rotateZ($1)")>]
    let rotateZ (p5: P5) (angle: float) : Unit = jsNative

    [<Emit("$0.translate($1, $2)")>]
    let translate (p5: P5) (x: float) (y: float) : Unit = jsNative

    [<Emit("$0.translate($1, $2, $3)")>]
    let translateZ (p5: P5) (x: float) (y: float) (z: float) : Unit = jsNative

    let translate3D = translateZ

    [<Emit("$0.translate($1)")>]
    let translateFromVector (p5: P5) (v: P5Vector) : Unit = jsNative

    [<Emit("$0.scale($1)")>]
    let scale (p5: P5) (s: float) : Unit = jsNative

    [<Emit("$0.scale($1, $2)")>]
    let scaleXY (p5: P5) (x: float) (y: float) : Unit = jsNative

    [<Emit("$0.scale($1, $2, $3)")>]
    let scale3D (p5: P5) (x: float) (y: float) (z: float) : Unit = jsNative

    let scaleXYZ = scale3D

    [<Emit("$0.scale($1)")>]
    let scaleFromVector (p5: P5) (v: P5Vector) : Unit = jsNative

    [<Emit("$0.scale($1)")>]
    let scaleFromValues (p5: P5) (values: float array) : Unit = jsNative

    [<Emit("$0.applyMatrix($1)")>]
    let applyMatrix (p5: P5) (matrix: float array) : Unit = jsNative

    [<Emit("$0.applyMatrix($1, $2, $3, $4, $5, $6)")>]
    let applyMatrix2x3 (p5: P5) (a: float) (b: float) (c: float) (d: float) (e: float) (f: float) : Unit = jsNative

    [<Emit("$0.applyMatrix($1, $2, $3, $4, $5, $6, $7, $8, $9, $10, $11, $12, $13, $14, $15, $16)")>]
    let applyMatrix4x4
        (p5: P5)
        (a: float)
        (b: float)
        (c: float)
        (d: float)
        (e: float)
        (f: float)
        (g: float)
        (h: float)
        (i: float)
        (j: float)
        (k: float)
        (l: float)
        (m: float)
        (n: float)
        (o: float)
        (p: float)
        : Unit =
        jsNative

    [<Emit("$0.resetMatrix()")>]
    let resetMatrix (p5: P5) : Unit = jsNative

    [<Emit("$0.shearX($1)")>]
    let shearX (p5: P5) (angle: float) : Unit = jsNative

    [<Emit("$0.shearY($1)")>]
    let shearY (p5: P5) (angle: float) : Unit = jsNative
