module P5Reference.Rendering.NoCanvas

open P5.Core
open P5.Rendering

let draw p5 = noCanvas p5

let run node = display node draw
