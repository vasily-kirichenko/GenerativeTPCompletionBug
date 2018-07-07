namespace LibraryWithTP
  
module Settings =
    open System
    open System.IO 
    open FSharp.Configuration
                  
    type Settings = YamlConfig<"Settings.yaml", ReadOnly=true>
    
    let Default = Settings()

