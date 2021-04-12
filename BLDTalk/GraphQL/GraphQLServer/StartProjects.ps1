wt -w 0 nt -d "$pwd\Product.API" --title Products dotnet run
wt -w 0 nt -d "$pwd\Inventory.API" --title Inventory dotnet run
wt -w 0 nt -d "$pwd\Order.Api" --title Order dotnet run
wt -w 0 nt -d "$pwd\Gateway" --title Gateway dotnet run