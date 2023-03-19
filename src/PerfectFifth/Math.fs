namespace P5

module Math =

    open P5.Core
    open Fable.Core

    let pi = 3.141592653589793

    let twoPi = 6.283185307179586

    let halfPi = 1.5707963267948966

    let quarterPi = 0.7853981633974483

    [<Emit("$0.map($1, $2, $3, $4, $5)")>]
    let map (p5: P5) (value: float) (start1: float) (stop1: float) (start2: float) (stop2: float) : float = jsNative

    [<Emit("$0.map($1, $2, $3, $4, $5 true)")>]
    let mapBounded (p5: P5) (value: float) (start1: float) (stop1: float) (start2: float) (stop2: float) : float =
        jsNative

    [<Emit("$0.radians($1)")>]
    let radians (p5: P5) (degrees: float) : float = jsNative

    type P5Vector =
        [<Emit("$0.toString()")>]
        member _.toString() = jsNative

    /// TODO: 3D / only x
    [<Emit("$0.createVector($1, $2)")>]
    let createVector (p5: P5) (x: float) (y: float) : P5Vector = jsNative

    let createVector2D = createVector
