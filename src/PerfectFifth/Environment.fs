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

    type DescribeDisplay =
        | Label
        | Fallback

    let private rawDescribeDisplay display =
        match display with
        | Label -> "label"
        | Fallback -> "fallback"

    [<Emit("$0.describe($1, $2)")>]
    let private describe_ (p5: P5) (text: string) (display: string) : Unit = jsNative

    [<Emit("$0.describe($1)")>]
    let describe (p5: P5) (text: string) : Unit = jsNative

    let describeWithDisplay (p5: P5) (text: string) (display: DescribeDisplay) =
        describe_ p5 text (rawDescribeDisplay display)

    [<Emit("$0.describeElement($1, $2, $3)")>]
    let private describeElement_ (p5: P5) (name: string) (text: string) (display: string) : Unit = jsNative

    [<Emit("$0.describeElement($1, 2)")>]
    let describeElement (p5: P5) (name: string) (text: string) : Unit = jsNative

    let describeElementWithDisplay (p5: P5) (name: string) (text: string) (display: DescribeDisplay) =
        describeElement_ p5 name text (rawDescribeDisplay display)
