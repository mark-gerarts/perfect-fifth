module P5Reference.Math.P5VectorReflect0

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Math

let draw p5 =
    let v = P5Vector.create (4, 6) // incoming vector, this example vector is heading to the right and downward
    let n = P5Vector.create (0, -1) // surface normal to a plane (this example normal points directly upwards)
    v.reflect n // v is reflected about the surface normal n.  v's components are now set to [4, -6]
    print p5 (string v)

let run node = display node draw
