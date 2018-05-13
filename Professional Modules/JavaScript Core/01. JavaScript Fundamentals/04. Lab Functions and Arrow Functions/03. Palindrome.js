function isPalindrome(n) {
    for (let i = 0; i < n.length / 2; i++) {
        if (n[i] != n[n.length - i - 1]) {
            return false;
        }
    }
    return true;
}
