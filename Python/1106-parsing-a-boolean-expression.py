class Solution:
    def parseBoolExpr(self, expression: str) -> bool:
        stack = []
        for ch in expression :
            if ch == ')' :
                contains_t, contains_f = False, False
                while (stack[-1] not in ['&', '|', '!']) :
                    pop = stack.pop()
                    if pop == 't' :
                        contains_t = True
                    elif pop == 'f' :
                        contains_f = True
                pop = stack.pop()
                if pop == '&' :
                    append = 'f' if contains_f else 't'
                elif pop == '|' :
                    append = 't' if contains_t else 'f'
                else :
                    append = 'f' if contains_t else 't'
                stack.append(append)
            else :
                stack.append(ch)
        return True if stack.pop() == 't' else False