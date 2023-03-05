namespace P5

module Environment =

    open Fable.Core
    open P5.Core

    [<Emit("$0.width")>]
    let width (p5: P5) : int = jsNative

    [<Emit("$0.height")>]
    let height (p5: P5) : int = jsNative

    [<Emit("$0.frameRate($1)")>]
    let framerate (p5: P5) (fps: int) : Unit = jsNative

    [<Emit("$0.getTargetFrameRate($1)")>]
    let getTargetFrameRate (p5: P5) : int = jsNative

    /// TODO: display (label/fallback)
    [<Emit("$0.describe($1)")>]
    let describe (p5: P5) (text: string) : Unit = jsNative
