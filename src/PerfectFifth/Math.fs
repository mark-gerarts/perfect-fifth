namespace P5

module Math =

    open P5.Core
    open Fable.Core

    let pi = 3.141592653589793

    let twoPi = 6.283185307179586

    let halfPi = 1.5707963267948966

    let quarterPi = 0.7853981633974483

    let tau = 6.283185307179586

    [<Emit("$0.map($1, $2, $3, $4, $5)")>]
    let map (p5: P5) (value: float) (start1: float) (stop1: float) (start2: float) (stop2: float) : float = jsNative

    [<Emit("$0.map($1, $2, $3, $4, $5, true)")>]
    let mapBounded (p5: P5) (value: float) (start1: float) (stop1: float) (start2: float) (stop2: float) : float =
        jsNative

    [<Emit("$0.norm($1, $2, $3)")>]
    let norm (p5: P5) (value: float) (start: float) (stop: float) : float = jsNative

    [<Emit("$0.radians($1)")>]
    let radians (p5: P5) (degrees: float) : float = jsNative

    [<Import("Vector", "p5")>]
    type P5Vector(?x: float, ?y: float, ?z: float) =
        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.fromAngle($1, $2)")>]
        static member fromAngleAndLength (angle: float) (length: float) : P5Vector = jsNative

        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.fromAngles($1, $2, $3)")>]
        static member fromAnglesAndLength (theta: float) (phi: float) (length: float) : P5Vector = jsNative

        [<Emit("$0.x")>]
        member _.x: float = jsNative

        [<Emit("$0.y")>]
        member _.y: float = jsNative

        [<Emit("$0.toString()")>]
        member _.toString() : string = jsNative

        [<Emit("$0.add($1, $2)")>]
        member _.addXY (x: float) (y: float) : Unit = jsNative

        [<Emit("$0.heading()")>]
        member _.heading() : float = jsNative

        [<Emit("$0.mag()")>]
        member _.mag() : float = jsNative

    let createVector: P5Vector = new P5Vector()

    let createVectorX (x: float) : P5Vector = new P5Vector(x)

    let createVectorXY (x: float) (y: float) : P5Vector = new P5Vector(x, y)

    let createVectorXYZ (x: float) (y: float) (z: float) : P5Vector = new P5Vector(x, y, z)

    let createVector1D = createVectorX

    let createVector2D = createVectorXY

    let createVector3D = createVectorXYZ

    [<Emit("$0.constrain($1, $2, $3)")>]
    let constrain (p5: P5) (n: float) (min: float) (max: float) : float = jsNative

    [<Emit("$0.dist($1, $2, $3, $4)")>]
    let dist (p5: P5) (x1: float) (y1: float) (x2: float) (y2: float) : float = jsNative

    [<Emit("$0.dist($1, $2, $3, $4, $5, $6)")>]
    let dist3D (p5: P5) (x1: float) (y1: float) (z1: float) (x2: float) (y2: float) (z2: float) : float = jsNative

    [<Emit("$0.lerp($1, $2, $3)")>]
    let lerp (p5: P5) (start: float) (stop: float) (amt: float) : float = jsNative

    [<Emit("$0.mag($1, $2)")>]
    let mag (p5: P5) (a: float) (b: float) : float = jsNative

    [<Emit("$0.fract($1)")>]
    let fract (p5: P5) (x: float) : float = jsNative
