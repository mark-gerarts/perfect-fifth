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

    [<Emit("$0.map($1, $2, $3, $4, $5 true)")>]
    let mapBounded (p5: P5) (value: float) (start1: float) (stop1: float) (start2: float) (stop2: float) : float =
        jsNative

    [<Emit("$0.radians($1)")>]
    let radians (p5: P5) (degrees: float) : float = jsNative

    type P5Vector =
        [<ImportDefault("p5")>]
        [<Emit("$0.Vector.fromAngle($1, $2)")>]
        static member fromAngleAndLength (angle: float) (length: float) : P5Vector = jsNative

        [<Emit("$0.x")>]
        member _.x: float = jsNative

        [<Emit("$0.y")>]
        member _.y: float = jsNative

        [<Emit("$0.toString()")>]
        member _.toString() : string = jsNative

        [<Emit("$0.add($1, $2)")>]
        member _.addXY (x: float) (y: float) : Unit = jsNative

    /// TODO: 3D / only x
    [<Emit("$0.createVector($1, $2)")>]
    let createVector (p5: P5) (x: float) (y: float) : P5Vector = jsNative

    let createVector2D = createVector
