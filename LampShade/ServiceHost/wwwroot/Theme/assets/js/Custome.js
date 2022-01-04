const cookieName = "cart-items";
function addToCart(id, name, price, picture) {
    debugger;
    let products = $.cookie(cookieName);
    if (products === undefined) {
        products = [];
    } else {
        products = JSON.parse(products);
    }

    const count = $("#productCount").val();
    const currentProduct = products.find(x => x.id === id);
    if (currentProduct !== undefined) {
        products.find(x => x.id = id).count = parseInt(currentProduct.count) + parseInt(count);
    } else {
        const product = {
            id,
            name,
            price,
            picture,
            count
        }
        products.push(product);
    }
    $.cookie(cookieName, JSON.stringify(products, { expires: 2, path: '/' }));
    updateCart();
}
function updateCart() {
    let products = $.cookie(cookieName);
    products = JSON.parse(products);
    $("#cart_items_count").text(products.length);

    const cartitemsWrapper = $("#cart_items_wrapper");

    cartitemsWrapper.html('');
    products.forEach(x => {
        let product = `<div class="single-cart-item">
                            <a href="javascript:void(0)" class="remove-icon" onclick="removeFromCart('${x.id}')">
                                <i class="ion-android-close"></i>
                            </a>
                            <div class="image">
                                <a href="single-product.html">
                                    <img src="/ProductPictures/${x.picture}"
                                         class="img-fluid" alt="">
                                </a>
                            </div>
                            <div class="content">
                                <p class="product-title">
                                    <a href="single-product.html">محصول: ${x.name}</a>
                                </p>
                                <p class="count">تعداد: ${x.count}</p>
                                <p class="count">قیمت واحد: ${x.price}</p>
                            </div>
                        </div>`;

        cartitemsWrapper.append(product);
    });
}

function removeFromCart(id) {
    let products = $.cookie(cookieName);
    products = JSON.parse(products);
    let itemToRemove = products.findIndex(x => x.id == id);
    products.splice(itemToRemove, 1);

    $.cookie(cookieName, JSON.stringify(products, { expires: 2, path: "/" }));
    updateCart(); 
}
function changeCartItemCount(id, totalId, count) {
    let products = $.cookie(cookieName);
    products = JSON.parse(products);
    var productIndex = products.findIndex(x => x.id == id);
    products[productIndex].count = count;
    var product = products[productIndex];
    const newPrice = parseInt(product.price) * parseInt(count);
    $(`#${totalId}`).text(newPrice);
    $.cookie(cookieName, JSON.stringify(products, { expires: 2, path: '/' }));
    updateCart();
}

