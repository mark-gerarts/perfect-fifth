module P5Reference.Environment.WindowWidth

open P5.Core
open P5.Environment
open P5.Rendering

let draw p5 =
    resizeCanvas p5 (windowWidth p5) (windowHeight p5)

let run node = display node draw
