// LineItemEntity.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class LineItemEntity
    {
        public LineItemEntity(
            global::System.String sku,
            global::System.Int32 quantity)
        {
            Sku = sku;
            Quantity = quantity;
        }

        public global::System.String Sku { get; }

        public global::System.Int32 Quantity { get; }
    }
}


// ProductEntity.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class ProductEntity
    {
        public ProductEntity(
            global::System.String name,
            global::System.String? sku,
            global::System.String description,
            global::System.String color,
            global::System.String size,
            global::System.Double price,
            global::System.String image,
            global::StrawberryShake.EntityId inventory)
        {
            Name = name;
            Sku = sku;
            Description = description;
            Color = color;
            Size = size;
            Price = price;
            Image = image;
            Inventory = inventory;
        }

        public global::System.String Name { get; }

        public global::System.String? Sku { get; }

        public global::System.String Description { get; }

        public global::System.String Color { get; }

        public global::System.String Size { get; }

        public global::System.Double Price { get; }

        public global::System.String Image { get; }

        public global::StrawberryShake.EntityId Inventory { get; }
    }
}


// InventoryEntity.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class InventoryEntity
    {
        public InventoryEntity(global::System.Int32 stock)
        {
            Stock = stock;
        }

        public global::System.Int32 Stock { get; }
    }
}


// GetOrdersResultFactory.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetOrdersResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<global::BlazorGQL.Api.GetOrdersResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::BlazorGQL.Api.State.LineItemEntity, GetOrders_Orders_LineItems_LineItem> _getOrders_Orders_LineItems_LineItemFromLineItemEntityMapper;

        public GetOrdersResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::BlazorGQL.Api.State.LineItemEntity, GetOrders_Orders_LineItems_LineItem> getOrders_Orders_LineItems_LineItemFromLineItemEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getOrders_Orders_LineItems_LineItemFromLineItemEntityMapper = getOrders_Orders_LineItems_LineItemFromLineItemEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getOrders_Orders_LineItems_LineItemFromLineItemEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::BlazorGQL.Api.IGetOrdersResult);

        public GetOrdersResult Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetOrdersResultInfo info)
            {
                return new GetOrdersResult(MapIGetOrders_OrdersArray(
                    info.Orders,
                    snapshot));
            }

            throw new global::System.ArgumentException("GetOrdersResultInfo expected.");
        }

        private global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.IGetOrders_Orders?>? MapIGetOrders_OrdersArray(
            global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.State.OrderData?>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                return null;
            }

            var orders = new global::System.Collections.Generic.List<global::BlazorGQL.Api.IGetOrders_Orders?>();

            foreach (global::BlazorGQL.Api.State.OrderData? child in list)
            {
                orders.Add(MapIGetOrders_Orders(
                    child,
                    snapshot));
            }

            return orders;
        }

        private global::BlazorGQL.Api.IGetOrders_Orders? MapIGetOrders_Orders(
            global::BlazorGQL.Api.State.OrderData? data,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (data is null)
            {
                return null;
            }

            IGetOrders_Orders returnValue = default!;

            if (data?.__typename.Equals(
                    "Order",
                    global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new GetOrders_Orders_Order(
                    data.OrderNumber ?? throw new global::System.ArgumentNullException(),
                    data.DeliveryName ?? throw new global::System.ArgumentNullException(),
                    data.DeliveryAddress1 ?? throw new global::System.ArgumentNullException(),
                    data.DeliveryAddress2,
                    data.DeliveryPostCode ?? throw new global::System.ArgumentNullException(),
                    data.DeliveryCity ?? throw new global::System.ArgumentNullException(),
                    data.DeliveryCountry ?? throw new global::System.ArgumentNullException(),
                    MapNonNullableIGetOrders_Orders_LineItemsNonNullableArray(
                        data.LineItems ?? throw new global::System.ArgumentNullException(),
                        snapshot));
            }
            else
            {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.IGetOrders_Orders_LineItems> MapNonNullableIGetOrders_Orders_LineItemsNonNullableArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                throw new global::System.ArgumentNullException();
            }

            var lineItems = new global::System.Collections.Generic.List<global::BlazorGQL.Api.IGetOrders_Orders_LineItems>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                lineItems.Add(MapNonNullableIGetOrders_Orders_LineItems(
                    child,
                    snapshot));
            }

            return lineItems;
        }

        private global::BlazorGQL.Api.IGetOrders_Orders_LineItems MapNonNullableIGetOrders_Orders_LineItems(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "LineItem",
                    global::System.StringComparison.Ordinal))
            {
                return _getOrders_Orders_LineItems_LineItemFromLineItemEntityMapper.Map(
                    snapshot.GetEntity<global::BlazorGQL.Api.State.LineItemEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(
                dataInfo,
                snapshot);
        }
    }
}


// GetOrdersResultInfo.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetOrdersResultInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;

        public GetOrdersResultInfo(
            global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.State.OrderData?>? orders,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            global::System.UInt64 version)
        {
            Orders = orders;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.State.OrderData?>? Orders { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public global::System.UInt64 Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetOrdersResultInfo(
                Orders,
                _entityIds,
                version);
        }
    }
}


// GetOrdersResult.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetOrdersResult
        : global::System.IEquatable<GetOrdersResult>
        , IGetOrdersResult
    {
        public GetOrdersResult(global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.IGetOrders_Orders?>? orders)
        {
            Orders = orders;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.IGetOrders_Orders?>? Orders { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetOrdersResult)obj);
        }

        public global::System.Boolean Equals(GetOrdersResult? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Orders,
                        other.Orders));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                if (!(Orders is null))
                {
                    foreach (var Orders_elm in Orders)
                    {
                        if (!(Orders_elm is null))
                        {
                            hash ^= 397 * Orders_elm.GetHashCode();
                        }
                    }
                }

                return hash;
            }
        }
    }
}


// GetOrders_Orders_Order.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetOrders_Orders_Order
        : global::System.IEquatable<GetOrders_Orders_Order>
        , IGetOrders_Orders_Order
    {
        public GetOrders_Orders_Order(
            global::System.String orderNumber,
            global::System.String deliveryName,
            global::System.String deliveryAddress1,
            global::System.String? deliveryAddress2,
            global::System.String deliveryPostCode,
            global::System.String deliveryCity,
            global::System.String deliveryCountry,
            global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.IGetOrders_Orders_LineItems> lineItems)
        {
            OrderNumber = orderNumber;
            DeliveryName = deliveryName;
            DeliveryAddress1 = deliveryAddress1;
            DeliveryAddress2 = deliveryAddress2;
            DeliveryPostCode = deliveryPostCode;
            DeliveryCity = deliveryCity;
            DeliveryCountry = deliveryCountry;
            LineItems = lineItems;
        }

        public global::System.String OrderNumber { get; }

        public global::System.String DeliveryName { get; }

        public global::System.String DeliveryAddress1 { get; }

        public global::System.String? DeliveryAddress2 { get; }

        public global::System.String DeliveryPostCode { get; }

        public global::System.String DeliveryCity { get; }

        public global::System.String DeliveryCountry { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.IGetOrders_Orders_LineItems> LineItems { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetOrders_Orders_Order)obj);
        }

        public global::System.Boolean Equals(GetOrders_Orders_Order? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (OrderNumber.Equals(other.OrderNumber))
                && DeliveryName.Equals(other.DeliveryName)
                && DeliveryAddress1.Equals(other.DeliveryAddress1)
                && ((DeliveryAddress2 is null && other.DeliveryAddress2 is null) ||DeliveryAddress2 != null && DeliveryAddress2.Equals(other.DeliveryAddress2))
                && DeliveryPostCode.Equals(other.DeliveryPostCode)
                && DeliveryCity.Equals(other.DeliveryCity)
                && DeliveryCountry.Equals(other.DeliveryCountry)
                && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        LineItems,
                        other.LineItems);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * OrderNumber.GetHashCode();

                hash ^= 397 * DeliveryName.GetHashCode();

                hash ^= 397 * DeliveryAddress1.GetHashCode();

                if (!(DeliveryAddress2 is null))
                {
                    hash ^= 397 * DeliveryAddress2.GetHashCode();
                }

                hash ^= 397 * DeliveryPostCode.GetHashCode();

                hash ^= 397 * DeliveryCity.GetHashCode();

                hash ^= 397 * DeliveryCountry.GetHashCode();

                foreach (var LineItems_elm in LineItems)
                {
                    hash ^= 397 * LineItems_elm.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetOrders_Orders_LineItems_LineItemFromLineItemEntityMapper.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetOrders_Orders_LineItems_LineItemFromLineItemEntityMapper
        : global::StrawberryShake.IEntityMapper<global::BlazorGQL.Api.State.LineItemEntity, GetOrders_Orders_LineItems_LineItem>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;

        public GetOrders_Orders_LineItems_LineItemFromLineItemEntityMapper(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        public GetOrders_Orders_LineItems_LineItem Map(
            global::BlazorGQL.Api.State.LineItemEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetOrders_Orders_LineItems_LineItem(
                entity.Sku,
                entity.Quantity);
        }
    }
}


// GetOrders_Orders_LineItems_LineItem.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetOrders_Orders_LineItems_LineItem
        : global::System.IEquatable<GetOrders_Orders_LineItems_LineItem>
        , IGetOrders_Orders_LineItems_LineItem
    {
        public GetOrders_Orders_LineItems_LineItem(
            global::System.String sku,
            global::System.Int32 quantity)
        {
            Sku = sku;
            Quantity = quantity;
        }

        public global::System.String Sku { get; }

        public global::System.Int32 Quantity { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetOrders_Orders_LineItems_LineItem)obj);
        }

        public global::System.Boolean Equals(GetOrders_Orders_LineItems_LineItem? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Sku.Equals(other.Sku))
                && Quantity == other.Quantity;
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Sku.GetHashCode();

                hash ^= 397 * Quantity.GetHashCode();

                return hash;
            }
        }
    }
}


// IGetOrdersResult.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetOrdersResult
    {
        public global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.IGetOrders_Orders?>? Orders { get; }
    }
}


// IOrderFields.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IOrderFields
    {
        public global::System.String OrderNumber { get; }

        public global::System.String DeliveryName { get; }

        public global::System.String DeliveryAddress1 { get; }

        public global::System.String? DeliveryAddress2 { get; }

        public global::System.String DeliveryPostCode { get; }

        public global::System.String DeliveryCity { get; }

        public global::System.String DeliveryCountry { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.IGetOrders_Orders_LineItems> LineItems { get; }
    }
}


// IGetOrders_Orders.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetOrders_Orders
        : IOrderFields
    {
    }
}


// IGetOrders_Orders_Order.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetOrders_Orders_Order
        : IGetOrders_Orders
    {
    }
}


// IGetOrders_Orders_LineItems.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetOrders_Orders_LineItems
    {
        public global::System.String Sku { get; }

        public global::System.Int32 Quantity { get; }
    }
}


// IGetOrders_Orders_LineItems_LineItem.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetOrders_Orders_LineItems_LineItem
        : IGetOrders_Orders_LineItems
    {
    }
}


// GetProductsResultFactory.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetProductsResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<global::BlazorGQL.Api.GetProductsResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::BlazorGQL.Api.State.ProductEntity, GetProducts_Products_Product> _getProducts_Products_ProductFromProductEntityMapper;

        public GetProductsResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::BlazorGQL.Api.State.ProductEntity, GetProducts_Products_Product> getProducts_Products_ProductFromProductEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getProducts_Products_ProductFromProductEntityMapper = getProducts_Products_ProductFromProductEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getProducts_Products_ProductFromProductEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::BlazorGQL.Api.IGetProductsResult);

        public GetProductsResult Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetProductsResultInfo info)
            {
                return new GetProductsResult(MapIGetProducts_ProductsArray(
                    info.Products,
                    snapshot));
            }

            throw new global::System.ArgumentException("GetProductsResultInfo expected.");
        }

        private global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.IGetProducts_Products?>? MapIGetProducts_ProductsArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                return null;
            }

            var products = new global::System.Collections.Generic.List<global::BlazorGQL.Api.IGetProducts_Products?>();

            foreach (global::StrawberryShake.EntityId? child in list)
            {
                products.Add(MapIGetProducts_Products(
                    child,
                    snapshot));
            }

            return products;
        }

        private global::BlazorGQL.Api.IGetProducts_Products? MapIGetProducts_Products(
            global::StrawberryShake.EntityId? entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "Product",
                    global::System.StringComparison.Ordinal))
            {
                return _getProducts_Products_ProductFromProductEntityMapper.Map(
                    snapshot.GetEntity<global::BlazorGQL.Api.State.ProductEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(
                dataInfo,
                snapshot);
        }
    }
}


// GetProductsResultInfo.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetProductsResultInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;

        public GetProductsResultInfo(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? products,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            global::System.UInt64 version)
        {
            Products = products;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? Products { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public global::System.UInt64 Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetProductsResultInfo(
                Products,
                _entityIds,
                version);
        }
    }
}


// GetProductsResult.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetProductsResult
        : global::System.IEquatable<GetProductsResult>
        , IGetProductsResult
    {
        public GetProductsResult(global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.IGetProducts_Products?>? products)
        {
            Products = products;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.IGetProducts_Products?>? Products { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetProductsResult)obj);
        }

        public global::System.Boolean Equals(GetProductsResult? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Products,
                        other.Products));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                if (!(Products is null))
                {
                    foreach (var Products_elm in Products)
                    {
                        if (!(Products_elm is null))
                        {
                            hash ^= 397 * Products_elm.GetHashCode();
                        }
                    }
                }

                return hash;
            }
        }
    }
}


// GetProducts_Products_ProductFromProductEntityMapper.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetProducts_Products_ProductFromProductEntityMapper
        : global::StrawberryShake.IEntityMapper<global::BlazorGQL.Api.State.ProductEntity, GetProducts_Products_Product>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::BlazorGQL.Api.State.InventoryEntity, GetProducts_Products_Inventory_Inventory> _getProducts_Products_Inventory_InventoryFromInventoryEntityMapper;

        public GetProducts_Products_ProductFromProductEntityMapper(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::BlazorGQL.Api.State.InventoryEntity, GetProducts_Products_Inventory_Inventory> getProducts_Products_Inventory_InventoryFromInventoryEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getProducts_Products_Inventory_InventoryFromInventoryEntityMapper = getProducts_Products_Inventory_InventoryFromInventoryEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getProducts_Products_Inventory_InventoryFromInventoryEntityMapper));
        }

        public GetProducts_Products_Product Map(
            global::BlazorGQL.Api.State.ProductEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetProducts_Products_Product(
                entity.Name,
                entity.Sku,
                entity.Description,
                entity.Color,
                entity.Size,
                entity.Price,
                entity.Image,
                MapNonNullableIGetProducts_Products_Inventory(
                    entity.Inventory,
                    snapshot));
        }

        private global::BlazorGQL.Api.IGetProducts_Products_Inventory MapNonNullableIGetProducts_Products_Inventory(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "Inventory",
                    global::System.StringComparison.Ordinal))
            {
                return _getProducts_Products_Inventory_InventoryFromInventoryEntityMapper.Map(
                    snapshot.GetEntity<global::BlazorGQL.Api.State.InventoryEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}


// GetProducts_Products_Product.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetProducts_Products_Product
        : global::System.IEquatable<GetProducts_Products_Product>
        , IGetProducts_Products_Product
    {
        public GetProducts_Products_Product(
            global::System.String name,
            global::System.String? sku,
            global::System.String description,
            global::System.String color,
            global::System.String size,
            global::System.Double price,
            global::System.String image,
            global::BlazorGQL.Api.IGetProducts_Products_Inventory inventory)
        {
            Name = name;
            Sku = sku;
            Description = description;
            Color = color;
            Size = size;
            Price = price;
            Image = image;
            Inventory = inventory;
        }

        public global::System.String Name { get; }

        public global::System.String? Sku { get; }

        public global::System.String Description { get; }

        public global::System.String Color { get; }

        public global::System.String Size { get; }

        public global::System.Double Price { get; }

        public global::System.String Image { get; }

        public global::BlazorGQL.Api.IGetProducts_Products_Inventory Inventory { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetProducts_Products_Product)obj);
        }

        public global::System.Boolean Equals(GetProducts_Products_Product? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Name.Equals(other.Name))
                && ((Sku is null && other.Sku is null) ||Sku != null && Sku.Equals(other.Sku))
                && Description.Equals(other.Description)
                && Color.Equals(other.Color)
                && Size.Equals(other.Size)
                && Price == other.Price
                && Image.Equals(other.Image)
                && Inventory.Equals(other.Inventory);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Name.GetHashCode();

                if (!(Sku is null))
                {
                    hash ^= 397 * Sku.GetHashCode();
                }

                hash ^= 397 * Description.GetHashCode();

                hash ^= 397 * Color.GetHashCode();

                hash ^= 397 * Size.GetHashCode();

                hash ^= 397 * Price.GetHashCode();

                hash ^= 397 * Image.GetHashCode();

                hash ^= 397 * Inventory.GetHashCode();

                return hash;
            }
        }
    }
}


// GetProducts_Products_Inventory_InventoryFromInventoryEntityMapper.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetProducts_Products_Inventory_InventoryFromInventoryEntityMapper
        : global::StrawberryShake.IEntityMapper<global::BlazorGQL.Api.State.InventoryEntity, GetProducts_Products_Inventory_Inventory>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;

        public GetProducts_Products_Inventory_InventoryFromInventoryEntityMapper(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        public GetProducts_Products_Inventory_Inventory Map(
            global::BlazorGQL.Api.State.InventoryEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetProducts_Products_Inventory_Inventory(entity.Stock);
        }
    }
}


// GetProducts_Products_Inventory_Inventory.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetProducts_Products_Inventory_Inventory
        : global::System.IEquatable<GetProducts_Products_Inventory_Inventory>
        , IGetProducts_Products_Inventory_Inventory
    {
        public GetProducts_Products_Inventory_Inventory(global::System.Int32 stock)
        {
            Stock = stock;
        }

        public global::System.Int32 Stock { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetProducts_Products_Inventory_Inventory)obj);
        }

        public global::System.Boolean Equals(GetProducts_Products_Inventory_Inventory? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Stock == other.Stock);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Stock.GetHashCode();

                return hash;
            }
        }
    }
}


// IGetProductsResult.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetProductsResult
    {
        public global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.IGetProducts_Products?>? Products { get; }
    }
}


// IGetProducts_Products.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetProducts_Products
    {
        public global::System.String Name { get; }

        public global::System.String? Sku { get; }

        public global::System.String Description { get; }

        public global::System.String Color { get; }

        public global::System.String Size { get; }

        public global::System.Double Price { get; }

        public global::System.String Image { get; }

        public global::BlazorGQL.Api.IGetProducts_Products_Inventory Inventory { get; }
    }
}


// IGetProducts_Products_Product.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetProducts_Products_Product
        : IGetProducts_Products
    {
    }
}


// IGetProducts_Products_Inventory.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetProducts_Products_Inventory
    {
        public global::System.Int32 Stock { get; }
    }
}


// IGetProducts_Products_Inventory_Inventory.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetProducts_Products_Inventory_Inventory
        : IGetProducts_Products_Inventory
    {
    }
}


// AddOrderResultFactory.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class AddOrderResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<global::BlazorGQL.Api.AddOrderResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;

        public AddOrderResultFactory(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::BlazorGQL.Api.IAddOrderResult);

        public AddOrderResult Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is AddOrderResultInfo info)
            {
                return new AddOrderResult(MapNonNullableIAddOrder_CreateOrder(
                    info.CreateOrder,
                    snapshot));
            }

            throw new global::System.ArgumentException("AddOrderResultInfo expected.");
        }

        private global::BlazorGQL.Api.IAddOrder_CreateOrder MapNonNullableIAddOrder_CreateOrder(
            global::BlazorGQL.Api.State.OrderData data,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IAddOrder_CreateOrder returnValue = default!;

            if (data.__typename.Equals(
                    "Order",
                    global::System.StringComparison.Ordinal))
            {
                returnValue = new AddOrder_CreateOrder_Order(
                    data.OrderNumber ?? throw new global::System.ArgumentNullException(),
                    data.DeliveryName ?? throw new global::System.ArgumentNullException());
            }
            else
            {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(
                dataInfo,
                snapshot);
        }
    }
}


// AddOrderResultInfo.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class AddOrderResultInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;

        public AddOrderResultInfo(
            global::BlazorGQL.Api.State.OrderData createOrder,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            global::System.UInt64 version)
        {
            CreateOrder = createOrder;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::BlazorGQL.Api.State.OrderData CreateOrder { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public global::System.UInt64 Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new AddOrderResultInfo(
                CreateOrder,
                _entityIds,
                version);
        }
    }
}


// AddOrderResult.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class AddOrderResult
        : global::System.IEquatable<AddOrderResult>
        , IAddOrderResult
    {
        public AddOrderResult(global::BlazorGQL.Api.IAddOrder_CreateOrder createOrder)
        {
            CreateOrder = createOrder;
        }

        public global::BlazorGQL.Api.IAddOrder_CreateOrder CreateOrder { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((AddOrderResult)obj);
        }

        public global::System.Boolean Equals(AddOrderResult? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (CreateOrder.Equals(other.CreateOrder));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * CreateOrder.GetHashCode();

                return hash;
            }
        }
    }
}


// AddOrder_CreateOrder_Order.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class AddOrder_CreateOrder_Order
        : global::System.IEquatable<AddOrder_CreateOrder_Order>
        , IAddOrder_CreateOrder_Order
    {
        public AddOrder_CreateOrder_Order(
            global::System.String orderNumber,
            global::System.String deliveryName)
        {
            OrderNumber = orderNumber;
            DeliveryName = deliveryName;
        }

        public global::System.String OrderNumber { get; }

        public global::System.String DeliveryName { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((AddOrder_CreateOrder_Order)obj);
        }

        public global::System.Boolean Equals(AddOrder_CreateOrder_Order? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (OrderNumber.Equals(other.OrderNumber))
                && DeliveryName.Equals(other.DeliveryName);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * OrderNumber.GetHashCode();

                hash ^= 397 * DeliveryName.GetHashCode();

                return hash;
            }
        }
    }
}


// IAddOrderResult.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IAddOrderResult
    {
        public global::BlazorGQL.Api.IAddOrder_CreateOrder CreateOrder { get; }
    }
}


// IAddOrder_CreateOrder.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IAddOrder_CreateOrder
    {
        public global::System.String OrderNumber { get; }

        public global::System.String DeliveryName { get; }
    }
}


// IAddOrder_CreateOrder_Order.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IAddOrder_CreateOrder_Order
        : IAddOrder_CreateOrder
    {
    }
}


// CreateOrderInputInputValueFormatter.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class CreateOrderInputInputValueFormatter
        : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _stringFormatter = default!;
        private global::StrawberryShake.Serialization.IInputValueFormatter _lineItemInputFormatter = default!;

        public global::System.String TypeName => "CreateOrderInput";

        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _stringFormatter = serializerResolver.GetInputValueFormatter("String");
            _lineItemInputFormatter = serializerResolver.GetInputValueFormatter("LineItemInput");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (runtimeValue is null)
            {
                return null;
            }

            if (!(runtimeValue is CreateOrderInput d))
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            return new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>[] {
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "deliveryName",
                    FormatDeliveryName(d.DeliveryName)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "deliveryAddress1",
                    FormatDeliveryAddress1(d.DeliveryAddress1)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "deliveryAddress2",
                    FormatDeliveryAddress2(d.DeliveryAddress2)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "deliveryCity",
                    FormatDeliveryCity(d.DeliveryCity)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "deliveryPostCode",
                    FormatDeliveryPostCode(d.DeliveryPostCode)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "deliveryCountry",
                    FormatDeliveryCountry(d.DeliveryCountry)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "lineItems",
                    FormatLineItems(d.LineItems))
            };
        }

        private global::System.Object? FormatDeliveryName(global::System.String value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _stringFormatter.Format(value);
        }

        private global::System.Object? FormatDeliveryAddress1(global::System.String value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _stringFormatter.Format(value);
        }

        private global::System.Object? FormatDeliveryAddress2(global::System.String? value)
        {
            if (!(value is null))
            {
                return _stringFormatter.Format(value);
            }
            else
            {
                return value;
            }
        }

        private global::System.Object? FormatDeliveryCity(global::System.String value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _stringFormatter.Format(value);
        }

        private global::System.Object? FormatDeliveryPostCode(global::System.String value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _stringFormatter.Format(value);
        }

        private global::System.Object? FormatDeliveryCountry(global::System.String value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _stringFormatter.Format(value);
        }

        private global::System.Object? FormatLineItems(global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.LineItemInput> value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            var value_list = new global::System.Collections.Generic.List<global::System.Object?>();

            foreach (var value_elm in value)
            {
                if (value_elm is null)
                {
                    throw new global::System.ArgumentNullException(nameof(value_elm));
                }

                value_list.Add(_lineItemInputFormatter.Format(value_elm));
            }
            return value_list;
        }
    }
}


// CreateOrderInput.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class CreateOrderInput
    {
        public global::System.String DeliveryName { get; set; } = default!;

        public global::System.String DeliveryAddress1 { get; set; } = default!;

        public global::System.String? DeliveryAddress2 { get; set; } = default!;

        public global::System.String DeliveryCity { get; set; } = default!;

        public global::System.String DeliveryPostCode { get; set; } = default!;

        public global::System.String DeliveryCountry { get; set; } = default!;

        public global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.LineItemInput> LineItems { get; set; } = default!;
    }
}


// LineItemInputInputValueFormatter.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class LineItemInputInputValueFormatter
        : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _stringFormatter = default!;
        private global::StrawberryShake.Serialization.IInputValueFormatter _intFormatter = default!;

        public global::System.String TypeName => "LineItemInput";

        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _stringFormatter = serializerResolver.GetInputValueFormatter("String");
            _intFormatter = serializerResolver.GetInputValueFormatter("Int");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (runtimeValue is null)
            {
                return null;
            }

            if (!(runtimeValue is LineItemInput d))
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            return new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>[] {
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "sku",
                    FormatSku(d.Sku)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "quantity",
                    FormatQuantity(d.Quantity))
            };
        }

        private global::System.Object? FormatSku(global::System.String value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _stringFormatter.Format(value);
        }

        private global::System.Object? FormatQuantity(global::System.Int32 value)
        {
            return _intFormatter.Format(value);
        }
    }
}


// LineItemInput.cs
#nullable enable

namespace BlazorGQL.Api
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class LineItemInput
    {
        public global::System.String Sku { get; set; } = default!;

        public global::System.Int32 Quantity { get; set; } = default!;
    }
}


// GetOrdersQueryDocument.cs
#nullable enable

namespace BlazorGQL.Api
{
    /// <summary>
    /// Represents the operation service of the GetOrders GraphQL operation
    /// <code>
    /// query GetOrders {
    ///   orders {
    ///     __typename
    ///     ... orderFields
    ///   }
    /// }
    /// 
    /// fragment orderFields on Order {
    ///   orderNumber
    ///   deliveryName
    ///   deliveryAddress1
    ///   deliveryAddress2
    ///   deliveryPostCode
    ///   deliveryCity
    ///   deliveryCountry
    ///   lineItems {
    ///     __typename
    ///     sku
    ///     quantity
    ///     ... on LineItem {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetOrdersQueryDocument
        : global::StrawberryShake.IDocument
    {
        private GetOrdersQueryDocument()
        {
        }

        public static GetOrdersQueryDocument Instance { get; } = new GetOrdersQueryDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;

        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{ 0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x4f, 0x72, 0x64, 0x65, 0x72, 0x73, 0x20, 0x7b, 0x20, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x46, 0x69, 0x65, 0x6c, 0x64, 0x73, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x46, 0x69, 0x65, 0x6c, 0x64, 0x73, 0x20, 0x6f, 0x6e, 0x20, 0x4f, 0x72, 0x64, 0x65, 0x72, 0x20, 0x7b, 0x20, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x4e, 0x75, 0x6d, 0x62, 0x65, 0x72, 0x20, 0x64, 0x65, 0x6c, 0x69, 0x76, 0x65, 0x72, 0x79, 0x4e, 0x61, 0x6d, 0x65, 0x20, 0x64, 0x65, 0x6c, 0x69, 0x76, 0x65, 0x72, 0x79, 0x41, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x31, 0x20, 0x64, 0x65, 0x6c, 0x69, 0x76, 0x65, 0x72, 0x79, 0x41, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x32, 0x20, 0x64, 0x65, 0x6c, 0x69, 0x76, 0x65, 0x72, 0x79, 0x50, 0x6f, 0x73, 0x74, 0x43, 0x6f, 0x64, 0x65, 0x20, 0x64, 0x65, 0x6c, 0x69, 0x76, 0x65, 0x72, 0x79, 0x43, 0x69, 0x74, 0x79, 0x20, 0x64, 0x65, 0x6c, 0x69, 0x76, 0x65, 0x72, 0x79, 0x43, 0x6f, 0x75, 0x6e, 0x74, 0x72, 0x79, 0x20, 0x6c, 0x69, 0x6e, 0x65, 0x49, 0x74, 0x65, 0x6d, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x73, 0x6b, 0x75, 0x20, 0x71, 0x75, 0x61, 0x6e, 0x74, 0x69, 0x74, 0x79, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x4c, 0x69, 0x6e, 0x65, 0x49, 0x74, 0x65, 0x6d, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d };

        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "b67f7ba7be5e13dca6bce073ddb2ed4380f24650");

        public override global::System.String ToString()
        {
            #if NETSTANDARD2_0
            return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
            #else
            return global::System.Text.Encoding.UTF8.GetString(Body);
            #endif
        }
    }
}


// GetOrdersQuery.cs
#nullable enable

namespace BlazorGQL.Api
{
    /// <summary>
    /// Represents the operation service of the GetOrders GraphQL operation
    /// <code>
    /// query GetOrders {
    ///   orders {
    ///     __typename
    ///     ... orderFields
    ///   }
    /// }
    /// 
    /// fragment orderFields on Order {
    ///   orderNumber
    ///   deliveryName
    ///   deliveryAddress1
    ///   deliveryAddress2
    ///   deliveryPostCode
    ///   deliveryCity
    ///   deliveryCountry
    ///   lineItems {
    ///     __typename
    ///     sku
    ///     quantity
    ///     ... on LineItem {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetOrdersQuery
        : global::BlazorGQL.Api.IGetOrdersQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetOrdersResult> _operationExecutor;

        public GetOrdersQuery(global::StrawberryShake.IOperationExecutor<IGetOrdersResult> operationExecutor)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetOrdersResult);

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetOrdersResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest();

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetOrdersResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest();
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest()
        {

            return CreateRequest(null);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {

            return new global::StrawberryShake.OperationRequest(
                id: GetOrdersQueryDocument.Instance.Hash.Value,
                name: "GetOrders",
                document: GetOrdersQueryDocument.Instance,
                strategy: global::StrawberryShake.RequestStrategy.Default);
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest();
        }
    }
}


// IGetOrdersQuery.cs
#nullable enable

namespace BlazorGQL.Api
{
    /// <summary>
    /// Represents the operation service of the GetOrders GraphQL operation
    /// <code>
    /// query GetOrders {
    ///   orders {
    ///     __typename
    ///     ... orderFields
    ///   }
    /// }
    /// 
    /// fragment orderFields on Order {
    ///   orderNumber
    ///   deliveryName
    ///   deliveryAddress1
    ///   deliveryAddress2
    ///   deliveryPostCode
    ///   deliveryCity
    ///   deliveryCountry
    ///   lineItems {
    ///     __typename
    ///     sku
    ///     quantity
    ///     ... on LineItem {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetOrdersQuery
        : global::StrawberryShake.IOperationRequestFactory
    {
        global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetOrdersResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default);

        global::System.IObservable<global::StrawberryShake.IOperationResult<IGetOrdersResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null);
    }
}


// GetProductsQueryDocument.cs
#nullable enable

namespace BlazorGQL.Api
{
    /// <summary>
    /// Represents the operation service of the GetProducts GraphQL operation
    /// <code>
    /// query GetProducts {
    ///   products {
    ///     __typename
    ///     name
    ///     sku
    ///     description
    ///     color
    ///     size
    ///     price
    ///     image
    ///     inventory {
    ///       __typename
    ///       stock
    ///       ... on Inventory {
    ///         id
    ///       }
    ///     }
    ///     ... on Product {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetProductsQueryDocument
        : global::StrawberryShake.IDocument
    {
        private GetProductsQueryDocument()
        {
        }

        public static GetProductsQueryDocument Instance { get; } = new GetProductsQueryDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;

        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{ 0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x50, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x73, 0x20, 0x7b, 0x20, 0x70, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x73, 0x6b, 0x75, 0x20, 0x64, 0x65, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x63, 0x6f, 0x6c, 0x6f, 0x72, 0x20, 0x73, 0x69, 0x7a, 0x65, 0x20, 0x70, 0x72, 0x69, 0x63, 0x65, 0x20, 0x69, 0x6d, 0x61, 0x67, 0x65, 0x20, 0x69, 0x6e, 0x76, 0x65, 0x6e, 0x74, 0x6f, 0x72, 0x79, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x73, 0x74, 0x6f, 0x63, 0x6b, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x49, 0x6e, 0x76, 0x65, 0x6e, 0x74, 0x6f, 0x72, 0x79, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x50, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d };

        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "c1685da4be850f047bf7015f92d2e05602afb359");

        public override global::System.String ToString()
        {
            #if NETSTANDARD2_0
            return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
            #else
            return global::System.Text.Encoding.UTF8.GetString(Body);
            #endif
        }
    }
}


// GetProductsQuery.cs
#nullable enable

namespace BlazorGQL.Api
{
    /// <summary>
    /// Represents the operation service of the GetProducts GraphQL operation
    /// <code>
    /// query GetProducts {
    ///   products {
    ///     __typename
    ///     name
    ///     sku
    ///     description
    ///     color
    ///     size
    ///     price
    ///     image
    ///     inventory {
    ///       __typename
    ///       stock
    ///       ... on Inventory {
    ///         id
    ///       }
    ///     }
    ///     ... on Product {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetProductsQuery
        : global::BlazorGQL.Api.IGetProductsQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetProductsResult> _operationExecutor;

        public GetProductsQuery(global::StrawberryShake.IOperationExecutor<IGetProductsResult> operationExecutor)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetProductsResult);

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetProductsResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest();

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetProductsResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest();
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest()
        {

            return CreateRequest(null);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {

            return new global::StrawberryShake.OperationRequest(
                id: GetProductsQueryDocument.Instance.Hash.Value,
                name: "GetProducts",
                document: GetProductsQueryDocument.Instance,
                strategy: global::StrawberryShake.RequestStrategy.Default);
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest();
        }
    }
}


// IGetProductsQuery.cs
#nullable enable

namespace BlazorGQL.Api
{
    /// <summary>
    /// Represents the operation service of the GetProducts GraphQL operation
    /// <code>
    /// query GetProducts {
    ///   products {
    ///     __typename
    ///     name
    ///     sku
    ///     description
    ///     color
    ///     size
    ///     price
    ///     image
    ///     inventory {
    ///       __typename
    ///       stock
    ///       ... on Inventory {
    ///         id
    ///       }
    ///     }
    ///     ... on Product {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetProductsQuery
        : global::StrawberryShake.IOperationRequestFactory
    {
        global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetProductsResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default);

        global::System.IObservable<global::StrawberryShake.IOperationResult<IGetProductsResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null);
    }
}


// AddOrderMutationDocument.cs
#nullable enable

namespace BlazorGQL.Api
{
    /// <summary>
    /// Represents the operation service of the AddOrder GraphQL operation
    /// <code>
    /// mutation AddOrder($input: CreateOrderInput!) {
    ///   createOrder(createOrderInput: $input) {
    ///     __typename
    ///     orderNumber
    ///     deliveryName
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class AddOrderMutationDocument
        : global::StrawberryShake.IDocument
    {
        private AddOrderMutationDocument()
        {
        }

        public static AddOrderMutationDocument Instance { get; } = new AddOrderMutationDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Mutation;

        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{ 0x6d, 0x75, 0x74, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x41, 0x64, 0x64, 0x4f, 0x72, 0x64, 0x65, 0x72, 0x28, 0x24, 0x69, 0x6e, 0x70, 0x75, 0x74, 0x3a, 0x20, 0x43, 0x72, 0x65, 0x61, 0x74, 0x65, 0x4f, 0x72, 0x64, 0x65, 0x72, 0x49, 0x6e, 0x70, 0x75, 0x74, 0x21, 0x29, 0x20, 0x7b, 0x20, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x4f, 0x72, 0x64, 0x65, 0x72, 0x28, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x4f, 0x72, 0x64, 0x65, 0x72, 0x49, 0x6e, 0x70, 0x75, 0x74, 0x3a, 0x20, 0x24, 0x69, 0x6e, 0x70, 0x75, 0x74, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x4e, 0x75, 0x6d, 0x62, 0x65, 0x72, 0x20, 0x64, 0x65, 0x6c, 0x69, 0x76, 0x65, 0x72, 0x79, 0x4e, 0x61, 0x6d, 0x65, 0x20, 0x7d, 0x20, 0x7d };

        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "478adbbbac7aa54d589afd1209526e00945f4117");

        public override global::System.String ToString()
        {
            #if NETSTANDARD2_0
            return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
            #else
            return global::System.Text.Encoding.UTF8.GetString(Body);
            #endif
        }
    }
}


// AddOrderMutation.cs
#nullable enable

namespace BlazorGQL.Api
{
    /// <summary>
    /// Represents the operation service of the AddOrder GraphQL operation
    /// <code>
    /// mutation AddOrder($input: CreateOrderInput!) {
    ///   createOrder(createOrderInput: $input) {
    ///     __typename
    ///     orderNumber
    ///     deliveryName
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class AddOrderMutation
        : global::BlazorGQL.Api.IAddOrderMutation
    {
        private readonly global::StrawberryShake.IOperationExecutor<IAddOrderResult> _operationExecutor;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _createOrderInputFormatter;

        public AddOrderMutation(
            global::StrawberryShake.IOperationExecutor<IAddOrderResult> operationExecutor,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
            _createOrderInputFormatter = serializerResolver.GetInputValueFormatter("CreateOrderInput");
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IAddOrderResult);

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IAddOrderResult>> ExecuteAsync(
            global::BlazorGQL.Api.CreateOrderInput input,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(input);

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IAddOrderResult>> Watch(
            global::BlazorGQL.Api.CreateOrderInput input,
            global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(input);
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::BlazorGQL.Api.CreateOrderInput input)
        {
            var variables = new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>();

            variables.Add(
                "input",
                FormatInput(input));

            return CreateRequest(variables);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {

            return new global::StrawberryShake.OperationRequest(
                id: AddOrderMutationDocument.Instance.Hash.Value,
                name: "AddOrder",
                document: AddOrderMutationDocument.Instance,
                strategy: global::StrawberryShake.RequestStrategy.Default,
                variables:variables);
        }

        private global::System.Object? FormatInput(global::BlazorGQL.Api.CreateOrderInput value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _createOrderInputFormatter.Format(value);
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest(variables!);
        }
    }
}


// IAddOrderMutation.cs
#nullable enable

namespace BlazorGQL.Api
{
    /// <summary>
    /// Represents the operation service of the AddOrder GraphQL operation
    /// <code>
    /// mutation AddOrder($input: CreateOrderInput!) {
    ///   createOrder(createOrderInput: $input) {
    ///     __typename
    ///     orderNumber
    ///     deliveryName
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IAddOrderMutation
        : global::StrawberryShake.IOperationRequestFactory
    {
        global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IAddOrderResult>> ExecuteAsync(
            global::BlazorGQL.Api.CreateOrderInput input,
            global::System.Threading.CancellationToken cancellationToken = default);

        global::System.IObservable<global::StrawberryShake.IOperationResult<IAddOrderResult>> Watch(
            global::BlazorGQL.Api.CreateOrderInput input,
            global::StrawberryShake.ExecutionStrategy? strategy = null);
    }
}


// GetOrdersBuilder.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetOrdersBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::BlazorGQL.Api.IGetOrdersResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::BlazorGQL.Api.IGetOrdersResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _iDParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;

        public GetOrdersBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer idSerializer,
            global::StrawberryShake.IOperationResultDataFactory<global::BlazorGQL.Api.IGetOrdersResult> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer
                 ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _iDParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("ID")
                 ?? throw new global::System.ArgumentException("No serializer for type `ID` found.");
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int")
                 ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetOrdersResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetOrdersResult Result, GetOrdersResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;

            try
            {
                if (response.Body != null)
                {
                    if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement) && dataElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        data = BuildData(dataElement);
                    }
                    if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                    {
                        errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                    }
                }
            }
            catch(global::System.Exception ex)
            {
                errors = new global::StrawberryShake.IClientError[] {
                    new global::StrawberryShake.ClientError(
                        ex.Message,
                        exception: ex)
                };
            }

            return new global::StrawberryShake.OperationResult<IGetOrdersResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                errors);
        }

        private (IGetOrdersResult, GetOrdersResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default!;

            global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.State.OrderData?>? ordersId = default!;
            _entityStore.Update(session => 
            {
                ordersId = DeserializeIGetOrders_OrdersArray(
                    session,
                    global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "orders"),
                    entityIds);

                snapshot = session.CurrentSnapshot;
            });

            var resultInfo = new GetOrdersResultInfo(
                ordersId,
                entityIds,
                snapshot.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::System.Collections.Generic.IReadOnlyList<global::BlazorGQL.Api.State.OrderData?>? DeserializeIGetOrders_OrdersArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var orders = new global::System.Collections.Generic.List<global::BlazorGQL.Api.State.OrderData?>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                orders.Add(DeserializeIGetOrders_Orders(
                    session,
                    child,
                    entityIds));
            }

            return orders;
        }

        private global::BlazorGQL.Api.State.OrderData? DeserializeIGetOrders_Orders(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var typename = obj.Value
                .GetProperty("__typename")
                .GetString();

            if (typename?.Equals("Order", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::BlazorGQL.Api.State.OrderData(
                    typename,
                    orderNumber: DeserializeNonNullableString(
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "orderNumber")),
                    deliveryName: DeserializeNonNullableString(
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "deliveryName")),
                    deliveryAddress1: DeserializeNonNullableString(
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "deliveryAddress1")),
                    deliveryAddress2: DeserializeString(
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "deliveryAddress2")),
                    deliveryPostCode: DeserializeNonNullableString(
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "deliveryPostCode")),
                    deliveryCity: DeserializeNonNullableString(
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "deliveryCity")),
                    deliveryCountry: DeserializeNonNullableString(
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "deliveryCountry")),
                    lineItems: UpdateNonNullableIGetOrders_Orders_LineItemsEntityNonNullableArray(
                        session,
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "lineItems"),
                        entityIds));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _iDParser.Parse(obj.Value.GetString()!);
        }

        private global::System.String? DeserializeString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> UpdateNonNullableIGetOrders_Orders_LineItemsEntityNonNullableArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var lineItems = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                lineItems.Add(UpdateNonNullableIGetOrders_Orders_LineItemsEntity(
                    session,
                    child,
                    entityIds));
            }

            return lineItems;
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIGetOrders_Orders_LineItemsEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "LineItem",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::BlazorGQL.Api.State.LineItemEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::BlazorGQL.Api.State.LineItemEntity(
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "sku")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "quantity"))));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::BlazorGQL.Api.State.LineItemEntity(
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "sku")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "quantity"))));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Int32 DeserializeNonNullableInt32(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt32()!);
        }
    }
}


// GetProductsBuilder.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetProductsBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::BlazorGQL.Api.IGetProductsResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::BlazorGQL.Api.IGetProductsResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Double, global::System.Double> _floatParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;

        public GetProductsBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer idSerializer,
            global::StrawberryShake.IOperationResultDataFactory<global::BlazorGQL.Api.IGetProductsResult> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer
                 ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
            _floatParser = serializerResolver.GetLeafValueParser<global::System.Double, global::System.Double>("Float")
                 ?? throw new global::System.ArgumentException("No serializer for type `Float` found.");
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int")
                 ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetProductsResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetProductsResult Result, GetProductsResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;

            try
            {
                if (response.Body != null)
                {
                    if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement) && dataElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        data = BuildData(dataElement);
                    }
                    if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                    {
                        errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                    }
                }
            }
            catch(global::System.Exception ex)
            {
                errors = new global::StrawberryShake.IClientError[] {
                    new global::StrawberryShake.ClientError(
                        ex.Message,
                        exception: ex)
                };
            }

            return new global::StrawberryShake.OperationResult<IGetProductsResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                errors);
        }

        private (IGetProductsResult, GetProductsResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default!;

            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? productsId = default!;
            _entityStore.Update(session => 
            {
                productsId = UpdateIGetProducts_ProductsEntityArray(
                    session,
                    global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "products"),
                    entityIds);

                snapshot = session.CurrentSnapshot;
            });

            var resultInfo = new GetProductsResultInfo(
                productsId,
                entityIds,
                snapshot.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? UpdateIGetProducts_ProductsEntityArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var products = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId?>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                products.Add(UpdateIGetProducts_ProductsEntity(
                    session,
                    child,
                    entityIds));
            }

            return products;
        }

        private global::StrawberryShake.EntityId? UpdateIGetProducts_ProductsEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Product",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::BlazorGQL.Api.State.ProductEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::BlazorGQL.Api.State.ProductEntity(
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "sku")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "description")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "color")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "size")),
                            DeserializeNonNullableDouble(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "price")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "image")),
                            UpdateNonNullableIGetProducts_Products_InventoryEntity(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "inventory"),
                                entityIds)));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::BlazorGQL.Api.State.ProductEntity(
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "sku")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "description")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "color")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "size")),
                            DeserializeNonNullableDouble(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "price")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "image")),
                            UpdateNonNullableIGetProducts_Products_InventoryEntity(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "inventory"),
                                entityIds)));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::System.String? DeserializeString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::System.Double DeserializeNonNullableDouble(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _floatParser.Parse(obj.Value.GetDouble()!);
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIGetProducts_Products_InventoryEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Inventory",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::BlazorGQL.Api.State.InventoryEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::BlazorGQL.Api.State.InventoryEntity(DeserializeNonNullableInt32(
                            global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                obj,
                                "stock"))));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::BlazorGQL.Api.State.InventoryEntity(DeserializeNonNullableInt32(
                            global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                obj,
                                "stock"))));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Int32 DeserializeNonNullableInt32(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt32()!);
        }
    }
}


// AddOrderBuilder.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class AddOrderBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::BlazorGQL.Api.IAddOrderResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::BlazorGQL.Api.IAddOrderResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _iDParser;

        public AddOrderBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer idSerializer,
            global::StrawberryShake.IOperationResultDataFactory<global::BlazorGQL.Api.IAddOrderResult> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer
                 ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int")
                 ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
            _iDParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("ID")
                 ?? throw new global::System.ArgumentException("No serializer for type `ID` found.");
        }

        public global::StrawberryShake.IOperationResult<IAddOrderResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IAddOrderResult Result, AddOrderResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;

            try
            {
                if (response.Body != null)
                {
                    if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement) && dataElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        data = BuildData(dataElement);
                    }
                    if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                    {
                        errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                    }
                }
            }
            catch(global::System.Exception ex)
            {
                errors = new global::StrawberryShake.IClientError[] {
                    new global::StrawberryShake.ClientError(
                        ex.Message,
                        exception: ex)
                };
            }

            return new global::StrawberryShake.OperationResult<IAddOrderResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                errors);
        }

        private (IAddOrderResult, AddOrderResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default!;

            _entityStore.Update(session => 
            {

                snapshot = session.CurrentSnapshot;
            });

            var resultInfo = new AddOrderResultInfo(
                DeserializeNonNullableIAddOrder_CreateOrder(
                    global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "createOrder")),
                entityIds,
                snapshot.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::BlazorGQL.Api.State.OrderData DeserializeNonNullableIAddOrder_CreateOrder(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var typename = obj.Value
                .GetProperty("__typename")
                .GetString();

            if (typename?.Equals("Order", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::BlazorGQL.Api.State.OrderData(
                    typename,
                    orderNumber: DeserializeNonNullableString(
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "orderNumber")),
                    deliveryName: DeserializeNonNullableString(
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "deliveryName")));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _iDParser.Parse(obj.Value.GetString()!);
        }
    }
}


// OrderData.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class OrderData
    {
        public OrderData(
            global::System.String __typename,
            global::System.String? orderNumber = null,
            global::System.String? deliveryName = null,
            global::System.String? deliveryAddress1 = null,
            global::System.String? deliveryAddress2 = null,
            global::System.String? deliveryPostCode = null,
            global::System.String? deliveryCity = null,
            global::System.String? deliveryCountry = null,
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? lineItems = null)
        {
            this.__typename = __typename
                 ?? throw new global::System.ArgumentNullException(nameof(__typename));
            OrderNumber = orderNumber;
            DeliveryName = deliveryName;
            DeliveryAddress1 = deliveryAddress1;
            DeliveryAddress2 = deliveryAddress2;
            DeliveryPostCode = deliveryPostCode;
            DeliveryCity = deliveryCity;
            DeliveryCountry = deliveryCountry;
            LineItems = lineItems;
        }

        public global::System.String __typename { get; }

        public global::System.String? OrderNumber { get; }

        public global::System.String? DeliveryName { get; }

        public global::System.String? DeliveryAddress1 { get; }

        public global::System.String? DeliveryAddress2 { get; }

        public global::System.String? DeliveryPostCode { get; }

        public global::System.String? DeliveryCity { get; }

        public global::System.String? DeliveryCountry { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? LineItems { get; }
    }
}


// ApiClient.cs
#nullable enable

namespace BlazorGQL.Api
{
    /// <summary>
    /// Represents the ApiClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class ApiClient
        : global::BlazorGQL.Api.IApiClient
    {
        private readonly global::BlazorGQL.Api.IGetOrdersQuery _getOrders;
        private readonly global::BlazorGQL.Api.IGetProductsQuery _getProducts;
        private readonly global::BlazorGQL.Api.IAddOrderMutation _addOrder;

        public ApiClient(
            global::BlazorGQL.Api.IGetOrdersQuery getOrders,
            global::BlazorGQL.Api.IGetProductsQuery getProducts,
            global::BlazorGQL.Api.IAddOrderMutation addOrder)
        {
            _getOrders = getOrders
                 ?? throw new global::System.ArgumentNullException(nameof(getOrders));
            _getProducts = getProducts
                 ?? throw new global::System.ArgumentNullException(nameof(getProducts));
            _addOrder = addOrder
                 ?? throw new global::System.ArgumentNullException(nameof(addOrder));
        }

        public static global::System.String ClientName => "ApiClient";

        public global::BlazorGQL.Api.IGetOrdersQuery GetOrders => _getOrders;

        public global::BlazorGQL.Api.IGetProductsQuery GetProducts => _getProducts;

        public global::BlazorGQL.Api.IAddOrderMutation AddOrder => _addOrder;
    }
}


// IApiClient.cs
#nullable enable

namespace BlazorGQL.Api
{
    /// <summary>
    /// Represents the ApiClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IApiClient
    {
        global::BlazorGQL.Api.IGetOrdersQuery GetOrders { get; }

        global::BlazorGQL.Api.IGetProductsQuery GetProducts { get; }

        global::BlazorGQL.Api.IAddOrderMutation AddOrder { get; }
    }
}


// ApiClientEntityIdFactory.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class ApiClientEntityIdFactory
        : global::StrawberryShake.IEntityIdSerializer
    {
        private static readonly global::System.Text.Json.JsonWriterOptions _options = new global::System.Text.Json.JsonWriterOptions(){ Indented = false };

        public global::StrawberryShake.EntityId Parse(global::System.Text.Json.JsonElement obj)
        {
            global::System.String __typename = obj
                .GetProperty("__typename")
                .GetString()!;

            return __typename switch
            {
                "LineItem" => ParseLineItemEntityId(
                    obj,
                    __typename),
                "Product" => ParseProductEntityId(
                    obj,
                    __typename),
                "Inventory" => ParseInventoryEntityId(
                    obj,
                    __typename),
                _ => throw new global::System.NotSupportedException()
            };
        }

        public global::System.String Format(global::StrawberryShake.EntityId entityId)
        {
            return entityId.Name switch
            {
                "LineItem" => FormatLineItemEntityId(entityId),
                "Product" => FormatProductEntityId(entityId),
                "Inventory" => FormatInventoryEntityId(entityId),
                _ => throw new global::System.NotSupportedException()
            };
        }

        private global::StrawberryShake.EntityId ParseLineItemEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetString()!);
        }

        private global::System.String FormatLineItemEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteString(
                "id",
                (global::System.String)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }

        private global::StrawberryShake.EntityId ParseProductEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetString()!);
        }

        private global::System.String FormatProductEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteString(
                "id",
                (global::System.String)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }

        private global::StrawberryShake.EntityId ParseInventoryEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetString()!);
        }

        private global::System.String FormatInventoryEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteString(
                "id",
                (global::System.String)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }
    }
}


// ApiClientServiceCollectionExtensions.cs
#nullable enable

namespace Microsoft.Extensions.DependencyInjection
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public static partial class ApiClientServiceCollectionExtensions
    {
        public static global::StrawberryShake.IClientBuilder<global::BlazorGQL.Api.State.ApiClientStoreAccessor> AddApiClient(
            this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services,
            global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => 
                {
                    var serviceCollection = ConfigureClientDefault(
                        sp,
                        strategy);

                    return new ClientServiceProvider(
                        global::Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions.BuildServiceProvider(serviceCollection));
                });

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => new global::BlazorGQL.Api.State.ApiClientStoreAccessor(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityIdSerializer>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory>>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory>>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp))));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::BlazorGQL.Api.GetOrdersQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::BlazorGQL.Api.GetProductsQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::BlazorGQL.Api.AddOrderMutation>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::BlazorGQL.Api.ApiClient>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::BlazorGQL.Api.IApiClient>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));

            return new global::StrawberryShake.ClientBuilder<global::BlazorGQL.Api.State.ApiClientStoreAccessor>(
                "ApiClient",
                services);
        }

        private static global::Microsoft.Extensions.DependencyInjection.IServiceCollection ConfigureClientDefault(
            global::System.IServiceProvider parentServices,
            global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            var services = new global::Microsoft.Extensions.DependencyInjection.ServiceCollection();
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IEntityStore, global::StrawberryShake.EntityStore>(services);
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IOperationStore>(
                services,
                sp => new global::StrawberryShake.OperationStore(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => 
                {
                    var clientFactory = global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Net.Http.IHttpClientFactory>(parentServices);
                    return new global::StrawberryShake.Transport.Http.HttpConnection(() => clientFactory.CreateClient("ApiClient"));
                });

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::BlazorGQL.Api.State.LineItemEntity, global::BlazorGQL.Api.GetOrders_Orders_LineItems_LineItem>, global::BlazorGQL.Api.State.GetOrders_Orders_LineItems_LineItemFromLineItemEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::BlazorGQL.Api.State.ProductEntity, global::BlazorGQL.Api.GetProducts_Products_Product>, global::BlazorGQL.Api.State.GetProducts_Products_ProductFromProductEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::BlazorGQL.Api.State.InventoryEntity, global::BlazorGQL.Api.GetProducts_Products_Inventory_Inventory>, global::BlazorGQL.Api.State.GetProducts_Products_Inventory_InventoryFromInventoryEntityMapper>(services);

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.StringSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.BooleanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ShortSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IntSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.LongSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.FloatSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DecimalSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UrlSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UuidSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IdSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateTimeSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteArraySerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.TimeSpanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::BlazorGQL.Api.CreateOrderInputInputValueFormatter>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::BlazorGQL.Api.LineItemInputInputValueFormatter>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializerResolver>(
                services,
                sp => new global::StrawberryShake.Serialization.SerializerResolver(
                    global::System.Linq.Enumerable.Concat(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(
                            parentServices),
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(
                            sp))));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::BlazorGQL.Api.IGetOrdersResult>, global::BlazorGQL.Api.State.GetOrdersResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::BlazorGQL.Api.IGetOrdersResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::BlazorGQL.Api.IGetOrdersQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::BlazorGQL.Api.IGetOrdersResult>, global::BlazorGQL.Api.State.GetOrdersBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::BlazorGQL.Api.IGetOrdersResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::BlazorGQL.Api.IGetOrdersResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::BlazorGQL.Api.IGetOrdersResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::BlazorGQL.Api.GetOrdersQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::BlazorGQL.Api.IGetOrdersQuery>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::BlazorGQL.Api.GetOrdersQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::BlazorGQL.Api.IGetProductsResult>, global::BlazorGQL.Api.State.GetProductsResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::BlazorGQL.Api.IGetProductsResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::BlazorGQL.Api.IGetProductsQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::BlazorGQL.Api.IGetProductsResult>, global::BlazorGQL.Api.State.GetProductsBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::BlazorGQL.Api.IGetProductsResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::BlazorGQL.Api.IGetProductsResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::BlazorGQL.Api.IGetProductsResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::BlazorGQL.Api.GetProductsQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::BlazorGQL.Api.IGetProductsQuery>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::BlazorGQL.Api.GetProductsQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::BlazorGQL.Api.IAddOrderResult>, global::BlazorGQL.Api.State.AddOrderResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::BlazorGQL.Api.IAddOrderResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::BlazorGQL.Api.IAddOrderMutation>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::BlazorGQL.Api.IAddOrderResult>, global::BlazorGQL.Api.State.AddOrderBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::BlazorGQL.Api.IAddOrderResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::BlazorGQL.Api.IAddOrderResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::BlazorGQL.Api.IAddOrderResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::BlazorGQL.Api.AddOrderMutation>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::BlazorGQL.Api.IAddOrderMutation>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::BlazorGQL.Api.AddOrderMutation>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityIdSerializer, global::BlazorGQL.Api.State.ApiClientEntityIdFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::BlazorGQL.Api.ApiClient>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::BlazorGQL.Api.IApiClient>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::BlazorGQL.Api.ApiClient>(sp));
            return services;
        }

        private class ClientServiceProvider
            : System.IServiceProvider
            , System.IDisposable
        {
            private readonly System.IServiceProvider _provider;

            public ClientServiceProvider(System.IServiceProvider provider)
            {
                _provider = provider;
            }

            public object? GetService(System.Type serviceType)
            {
                return _provider.GetService(serviceType);
            }

            public void Dispose()
            {
                if (_provider is System.IDisposable d)
                {
                    d.Dispose();
                }
            }
        }
    }
}


// ApiClientStoreAccessor.cs
#nullable enable

namespace BlazorGQL.Api.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class ApiClientStoreAccessor
        : global::StrawberryShake.StoreAccessor
    {
        public ApiClientStoreAccessor(
            global::StrawberryShake.IOperationStore operationStore,
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer entityIdSerializer,
            global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory> requestFactories,
            global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory> resultDataFactories)
            : base(
                operationStore,
                entityStore,
                entityIdSerializer,
                requestFactories,
                resultDataFactories)
        {
        }
    }
}


