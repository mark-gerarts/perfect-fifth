module P5Reference.Math.P5VectorArray0

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v = P5Vector.create (20, 30)
    print p5 (v.array () |> string) // Prints : Array [20, 30, 0]

let run node = display node draw
