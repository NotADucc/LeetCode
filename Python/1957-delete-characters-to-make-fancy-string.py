class Solution:
    def makeFancyString(self, s: str) -> str:
        output = []

        for ch in s :
            if len(output) < 2 or output[-2] != output[-1] or output[-1] != ch :
                output.append(ch)

        return "".join(output)
        