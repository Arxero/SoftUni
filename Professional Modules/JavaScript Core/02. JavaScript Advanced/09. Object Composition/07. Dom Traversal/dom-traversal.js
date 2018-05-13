function domTraversal(selector) {
    let $target = $(selector).children()
    if ($target.length == 0) {
        return $(selector).addClass('highlight')
    }

    let $next = $target
    while ($next.length) {
        $target = $next
        $next = $next.children()
    }
    $target.first().addClass('highlight')
    $target.first().parentsUntil($(selector).parent()).addClass('highlight')
}