namespace P5

module Util =

    open P5.Core
    open Fable.Core

    [<Emit("$0[$1]()")>]
    let internal emit0 (p5: P5) (method: string) : 'a = jsNative

    [<Emit("$0[$1]($2)")>]
    let internal emit1 (p5: P5) (method: string) (arg1: 'a) : 'b = jsNative

    [<Emit("$0[$1]($2, $3)")>]
    let internal emit2 (p5: P5) (method: string) (arg1: 'a) (arg2: 'b) : 'c = jsNative

    [<Emit("$0[$1]($2, $3, $4)")>]
    let internal emit3 (p5: P5) (method: string) (arg1: 'a) (arg2: 'b) (arg3: 'c) : 'd = jsNative

    [<Emit("$0[$1]($2, $3, $4, $5)")>]
    let internal emit4 (p5: P5) (method: string) (arg1: 'a) (arg2: 'b) (arg3: 'c) (arg4: 'd) : 'e = jsNative

    let failwithUnexpectedValue method =
        sprintf
            "Received invalid value for p5.%s. This is probably caused by a version mismatch between Perfect Fifth and P5"
            method
        |> failwith
