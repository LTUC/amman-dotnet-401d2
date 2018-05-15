# Example 2

# visually debugging,
def kth_element(k, a, l, r):
    p = partition(a, l, r)
    if p == k:
        return p[a]
    elif p > k:
        return kth_element(k, a, l, p - 1)
    else:
        return kth_element(k, a, p + 1, r)