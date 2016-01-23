namespace bug

module Library =
    open Serilog.Core
    open FSharp.Configuration

    type BugConfig = YamlConfig<"Bug.yaml">
    let bugConfig = BugConfig()

    type internal TypeTagRemover() =
        interface ILogEventEnricher with
            member this.Enrich(logEvent, _) =
                logEvent.Properties
                |> ignore