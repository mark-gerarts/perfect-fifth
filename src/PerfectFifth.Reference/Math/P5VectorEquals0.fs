module P5Reference.Math.P5VectorEquals0

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v1 = P5Vector.create (5, 10, 20)
    let v2 = P5Vector.create (5, 10, 20)
    let v3 = P5Vector.create (13, 10, 19)

    print p5 (v1.equals (v2.x, v2.y, v2.z) |> string) // true
    print p5 (v1.equals (v3.x, v3.y, v3.z) |> string) // false

let run node = display node draw
