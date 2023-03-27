module P5Reference.Rendering.CreateCanvas

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering

let draw p5 =
    // If you need the return value, use `createCanvasAndReturn`. Beware that
    // - because of translation issues from p5js to F# - this returns a "P5"
    // instance, and not a "p5.Renderer", as the documentations says.
    //
    // If you actually need the instance, I'm afraid you'll have to do some
    // unboxing. This is ugly but works. I feel this feature isn't that useful
    // to spend time on to improve (at this moment).
    //
    //    let cv = createCanvasAndReturn p5 100 100
    //    let cvRenderer = unbox<P5Renderer> cv
    //    cvRenderer.remove()
    //
    createCanvas p5 100 50
    background p5 (Grayscale 153)
    line p5 0 0 (width p5 |> float) (height p5 |> float)

let run node = display node draw
