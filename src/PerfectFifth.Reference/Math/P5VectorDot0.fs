module P5Reference.Math.P5VectorDot0

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v1 = P5Vector.create (1, 2, 3)
    let v2 = P5Vector.create (2, 3, 4)

    print p5 (v1.dotVector (v2) |> string) // Prints "20"

let run node = display node draw
