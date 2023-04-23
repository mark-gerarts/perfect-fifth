module P5Reference.Math.P5VectorEquals1

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v1 = P5Vector.create (10.0, 20.0, 30.0)
    let v2 = P5Vector.create (10.0, 20.0, 30.0)
    let v3 = P5Vector.create (0.0, 0.0, 0.0)
    print p5 (v1.equalsVector (v2) |> string) // true
    print p5 (v1.equalsVector (v3) |> string) // false

let run node = display node draw
