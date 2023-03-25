module P5Reference.Environment.DisplayWidth

open P5.Core
open P5.Environment
open P5.Rendering

let draw p5 =
    resizeCanvas p5 (displayWidth p5) (displayHeight p5)

let run node = display node draw
